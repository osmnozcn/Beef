/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Entities;
using Beef.Validation;
using Beef.Demo.Common.Entities;
using Beef.Demo.Business.DataSvc;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business
{
    /// <summary>
    /// Provides the Gender business functionality.
    /// </summary>
    public partial class GenderManager : IGenderManager
    {
        #region Private

        private Func<Guid, Task> _getOnPreValidateAsync = null;
        private Action<MultiValidator, Guid> _getOnValidate = null;
        private Func<Guid, Task> _getOnBeforeAsync = null;
        private Func<Gender, Guid, Task> _getOnAfterAsync = null;

        private Func<Gender, Task> _createOnPreValidateAsync = null;
        private Action<MultiValidator, Gender> _createOnValidate = null;
        private Func<Gender, Task> _createOnBeforeAsync = null;
        private Func<Gender, Task> _createOnAfterAsync = null;

        private Func<Gender, Guid, Task> _updateOnPreValidateAsync = null;
        private Action<MultiValidator, Gender, Guid> _updateOnValidate = null;
        private Func<Gender, Guid, Task> _updateOnBeforeAsync = null;
        private Func<Gender, Guid, Task> _updateOnAfterAsync = null;

        #endregion

        /// <summary>
        /// Gets the <see cref="Gender"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <returns>The selected <see cref="Gender"/> object where found; otherwise, <c>null</c>.</returns>
        public Task<Gender> GetAsync(Guid id)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Read;
                EntityBase.CleanUp(id);
                if (_getOnPreValidateAsync != null) await _getOnPreValidateAsync(id);

                MultiValidator.Create()
                    .Add(id.Validate(nameof(id)).Mandatory())
                    .Additional((__mv) => _getOnValidate?.Invoke(__mv, id))
                    .Run().ThrowOnError();

                if (_getOnBeforeAsync != null) await _getOnBeforeAsync(id);
                var __result = await GenderDataSvc.GetAsync(id);
                if (_getOnAfterAsync != null) await _getOnAfterAsync(__result, id);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Creates the <see cref="Gender"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/> object.</param>
        /// <returns>A refreshed <see cref="Gender"/> object.</returns>
        public Task<Gender> CreateAsync(Gender value)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Create;
                EntityBase.CleanUp(value);
                if (_createOnPreValidateAsync != null) await _createOnPreValidateAsync(value);

                MultiValidator.Create()
                    .Add(value.Validate(nameof(value)).Mandatory().Entity(new ReferenceDataValidator<Gender>()))
                    .Additional((__mv) => _createOnValidate?.Invoke(__mv, value))
                    .Run().ThrowOnError();

                if (_createOnBeforeAsync != null) await _createOnBeforeAsync(value);
                var __result = await GenderDataSvc.CreateAsync(value);
                if (_createOnAfterAsync != null) await _createOnAfterAsync(__result);
                Cleaner.Clean(__result);
                return __result;
            });
        }

        /// <summary>
        /// Updates the <see cref="Gender"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Gender"/> object.</param>
        /// <param name="id">The <see cref="Gender"/> identifier.</param>
        /// <returns>A refreshed <see cref="Gender"/> object.</returns>
        public Task<Gender> UpdateAsync(Gender value, Guid id)
        {
            return ManagerInvoker.Default.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Update;
                if (value != null) { value.Id = id; }
                EntityBase.CleanUp(value, id);
                if (_updateOnPreValidateAsync != null) await _updateOnPreValidateAsync(value, id);

                MultiValidator.Create()
                    .Add(value.Validate(nameof(value)).Mandatory().Entity(new ReferenceDataValidator<Gender>()))
                    .Additional((__mv) => _updateOnValidate?.Invoke(__mv, value, id))
                    .Run().ThrowOnError();

                if (_updateOnBeforeAsync != null) await _updateOnBeforeAsync(value, id);
                var __result = await GenderDataSvc.UpdateAsync(value);
                if (_updateOnAfterAsync != null) await _updateOnAfterAsync(__result, id);
                Cleaner.Clean(__result);
                return __result;
            });
        }
    }
}
