﻿# Manager (Domain Logic)

The *Manager* layer is primarily responsible for hosting the key business and/or workflow logic. This is also where the primary [validation](./Beef-Validation.md) is performed to ensure the consistency of the request before any further processing is performed.

<br>

## Usage

This layer is generally code-generated and provides options to provide a fully custom implementation, and has extension opportunities to inject additional logic into the processing pipeline.

The [`Operation`](./Entity-Operation-element.md) element within the `entity.xml` configuration primarily drives the output. There is a generated class per [`Entity`](./Entity-Entity-element.md) named `{Entity}Manager`.

There is also a corresonding interface named `I{Entity}Manager` generated so the likes of test mocking etc. can be employed.

<br/>

### Code-generated
 
An end-to-end code-generated processing pipeline generally consists of:

Step | Description
-|-
`ManagerInvoker` | The logic is wrapped by a [`ManagerInvoker`](../src/Beef.Core/Business/ManagerInvoker.cs). This enables the [`BusinessInvokerArgs`](../src/Beef.Core/Business/BusinessInvokerBase.cs) options to be specified, including [`DataContextScopeOption`](../src/Beef.Core/DataContextScopeOption.cs), [`TransactionScopeOption`](https://docs.microsoft.com/en-us/dotnet/api/system.transactions.transactionscopeoption) and `Exception` handler. These values are generally specified in the code-generation configuration.
`OperationType` | The [`ExecutionContext.OperationType`](../src/Beef.Core/ExecutionContext.cs) is set to specify the type of operation being performed (`Create`, `Read`, `Update` or `Delete`) so other functions down the call stack can infer operation intent.
`CleanUp` | Entity [`CleanUp`](../src/Beef.Core/Entities/Cleaner.cs) is the process of reviewing and updating the entity properties to make sure it is in a logical / consistent state.
`PreValidate` | The `PreValidate` extension opportunity; where set this will be invoked. This enables logic to be invoked _before_ the validation performed.
`Validation` | The [`MultiValidator`](../src/Beef.Core/Validation/MultiValidator.cs) is used to validate all input, including an `OnValidate` extension opportunity, to ensure data consistency before processing.
`OnBefore` | The `OnBefore` extension opportunity; where set this will be invoked. This enables logic to be invoked _before_ the primary `Operation` is performed.
`DataSvc` | The [`{Entity}DataSvc`](./Layer-DataSvc.md) layer is invoked to orchestrate the data processing.
`OnAfter` | The `OnAfter` extension opportunity; where set this will be invoked. This enables logic to be invoked _after_ the primary `Operation` is performed.
`CleanUp` | An Entity `CleanUp` of response before returning.

The following demonstrates the usage (a snippet from the sample [`PersonData`](../samples/Demo/Beef.Demo.Business/Generated/PersonManager.cs)):

``` csharp
public Task<Person> CreateAsync(Person value)
{
    return ManagerInvoker.Default.InvokeAsync(this, async () =>
    {
        ExecutionContext.Current.OperationType = OperationType.Create;
        EntityBase.CleanUp(value);
        if (_createOnPreValidateAsync != null) await _createOnPreValidateAsync(value);

        MultiValidator.Create()
            .Add(value.Validate(nameof(value)).Mandatory().Entity(PersonValidator.Default))
            .Additional((__mv) => _createOnValidate?.Invoke(__mv, value))
            .Run().ThrowOnError();

        if (_createOnBeforeAsync != null) await _createOnBeforeAsync(value);
        var __result = await PersonDataSvc.CreateAsync(value);
        if (_createOnAfterAsync != null) await _createOnAfterAsync(__result);
        Cleaner.Clean(__result);
        return __result;
    });
}
```

<br/>

### Custom

A custom (`OnImplementation`) processing pipeline generally consists of:

Step | Description
-|-
`ManagerInvoker` | The logic is wrapped by a [`ManagerInvoker`](../src/Beef.Core/Business/ManagerInvoker.cs). This enables the [`BusinessInvokerArgs`](../src/Beef.Core/Business/BusinessInvokerBase.cs) options to be specified, including [`DataContextScopeOption`](../src/Beef.Core/DataContextScopeOption.cs), [`TransactionScopeOption`](https://docs.microsoft.com/en-us/dotnet/api/system.transactions.transactionscopeoption) and `Exception` handler. These values are generally specified in the code-generation configuration.
`OnImplementation` | Invocation of a named `XxxxxOnImplementaionAsync` method that must be implemented in a non-generated partial class.

The following demonstrates the usage:

``` csharp
public Task AddAsync(Person person)
{
    return ManagerInvoker.Default.InvokeAsync(this, async () =>
    {
        ExecutionContext.Current.OperationType = OperationType.Unspecified;
        await AddOnImplementationAsync(person);
    });
}
```