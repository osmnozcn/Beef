/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Beef.Entities;
using Beef.WebApi;
using Newtonsoft.Json.Linq;
using Beef.Demo.Common.Entities;
using Beef.Demo.Common.Agents.ServiceAgents;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Agents
{
    /// <summary>
    /// Provides the Person Web API agent.
    /// </summary>
    public partial class PersonAgent : WebApiAgentBase, IPersonServiceAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonAgent"/> class.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> (where overridding the default value).</param>
        /// <param name="beforeRequest">The <see cref="Action{HttpRequestMessage}"/> to invoke before the <see cref="HttpRequestMessage">Http Request</see> is made (see <see cref="WebApiServiceAgentBase.BeforeRequest"/>).</param>
        public PersonAgent(HttpClient? httpClient = null, Action<HttpRequestMessage>? beforeRequest = null)
        {
            PersonServiceAgent = Beef.Factory.Create<IPersonServiceAgent>(httpClient, beforeRequest);
        }
        
        /// <summary>
        /// Gets the underlyng <see cref="IPersonServiceAgent"/> instance.
        /// </summary>
        public IPersonServiceAgent PersonServiceAgent { get; private set; }

        /// <summary>
        /// Creates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> CreateAsync(Person value, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.CreateAsync(Check.NotNull(value, nameof(value)), requestOptions);

        /// <summary>
        /// Deletes the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> DeleteAsync(Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.DeleteAsync(id, requestOptions);

        /// <summary>
        /// Gets the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> GetAsync(Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetAsync(id, requestOptions);

        /// <summary>
        /// Updates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> UpdateAsync(Person value, Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.UpdateAsync(Check.NotNull(value, nameof(value)), id, requestOptions);

        /// <summary>
        /// Patches the <see cref="Person"/> object.
        /// </summary>
        /// <param name="patchOption">The <see cref="WebApiPatchOption"/>.</param>
        /// <param name="value">The JSON patch value.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> PatchAsync(WebApiPatchOption patchOption, JToken value, Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.PatchAsync(patchOption, value, id, requestOptions);

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonCollectionResult>> GetAllAsync(PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetAllAsync(paging, requestOptions);

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonCollectionResult>> GetAll2Async(WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetAll2Async(requestOptions);

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonCollectionResult>> GetByArgsAsync(PersonArgs? args, PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetByArgsAsync(args, paging, requestOptions);

        /// <summary>
        /// Gets the <see cref="PersonDetail"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonDetailCollectionResult>> GetDetailByArgsAsync(PersonArgs? args, PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetDetailByArgsAsync(args, paging, requestOptions);

        /// <summary>
        /// Merge first <see cref="Person"/> into second.
        /// </summary>
        /// <param name="fromId">The from <see cref="Person"/> identifier.</param>
        /// <param name="toId">The to <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> MergeAsync(Guid fromId, Guid toId, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.MergeAsync(fromId, toId, requestOptions);

        /// <summary>
        /// Mark <see cref="Person"/>.
        /// </summary>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> MarkAsync(WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.MarkAsync(requestOptions);

        /// <summary>
        /// Gets the <see cref="PersonDetail"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonDetail>> GetDetailAsync(Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetDetailAsync(id, requestOptions);

        /// <summary>
        /// Updates the <see cref="PersonDetail"/> object.
        /// </summary>
        /// <param name="value">The <see cref="PersonDetail"/> object.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonDetail>> UpdateDetailAsync(PersonDetail value, Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.UpdateDetailAsync(Check.NotNull(value, nameof(value)), id, requestOptions);

        /// <summary>
        /// Patches the <see cref="Person"/> object.
        /// </summary>
        /// <param name="patchOption">The <see cref="WebApiPatchOption"/>.</param>
        /// <param name="value">The JSON patch value.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonDetail>> PatchDetailAsync(WebApiPatchOption patchOption, JToken value, Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.PatchDetailAsync(patchOption, value, id, requestOptions);

        /// <summary>
        /// Actually validating the FromBody parameter generation.
        /// </summary>
        /// <param name="person">The Person (see <see cref="Person"/>).</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> AddAsync(Person? person, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.AddAsync(person, requestOptions);

        /// <summary>
        /// Get Null.
        /// </summary>
        /// <param name="name">The Name.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person?>> GetNullAsync(string? name, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetNullAsync(name, requestOptions);

        /// <summary>
        /// Gets the <see cref="Person"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="PersonArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<PersonCollectionResult>> GetByArgsWithEfAsync(PersonArgs? args, PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetByArgsWithEfAsync(args, paging, requestOptions);

        /// <summary>
        /// Gets the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> GetWithEfAsync(Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.GetWithEfAsync(id, requestOptions);

        /// <summary>
        /// Creates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> CreateWithEfAsync(Person value, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.CreateWithEfAsync(Check.NotNull(value, nameof(value)), requestOptions);

        /// <summary>
        /// Updates the <see cref="Person"/> object.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> object.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<Person>> UpdateWithEfAsync(Person value, Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.UpdateWithEfAsync(Check.NotNull(value, nameof(value)), id, requestOptions);

        /// <summary>
        /// Deletes the <see cref="Person"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult> DeleteWithEfAsync(Guid id, WebApiRequestOptions? requestOptions = null)
            => PersonServiceAgent.DeleteWithEfAsync(id, requestOptions);
    }
}

#nullable restore