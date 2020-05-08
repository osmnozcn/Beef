/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using Beef.Demo.Business;
using Beef.Grpc;
using Grpc.Core;
using System.Net;
using System.Threading.Tasks;
using Beef.Demo.Common.Grpc;
using Beef.Demo.Common.Grpc.Proto;

namespace Beef.Demo.Api.Grpc
{
    /// <summary>
    /// Provides the <b>Robot</b> gRPC Server functionality.
    /// </summary>
    public partial class RobotService : RobotGrpcService.RobotGrpcServiceBase
    {
        /// <summary>
        /// Gets the <see cref="Robot"/> entity that matches the selection criteria.
        /// </summary>
        /// <param name="request">The <see cref="RobotGetRequest"/>.</param>
        /// <param name="context">The <see cref="ServerCallContext context"/>.</param>
        /// <returns>A <see cref="Robot"/>.</returns>
        public override Task<Robot> Get(RobotGetRequest request, ServerCallContext context)
        {
            return new GrpcService<Robot>(context, async () =>
            {
                var __req = request ?? new RobotGetRequest();
                var __result = await Factory.Create<IRobotManager>().GetAsync(Transformers.GuidToStringConverter.ConvertToSrce(__req.Id));
                return Transformers.Robot.MapToDest(__result!)!;
            }, operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound).ExecuteAsync();
        }

        /// <summary>
        /// Creates the <see cref="Robot"/> entity.
        /// </summary>
        /// <param name="request">The <see cref="RobotCreateRequest"/>.</param>
        /// <param name="context">The <see cref="ServerCallContext context"/>.</param>
        /// <returns>A <see cref="Robot"/>.</returns>
        public override Task<Robot> Create(RobotCreateRequest request, ServerCallContext context)
        {
            return new GrpcService<Robot>(context, async () =>
            {
                var __req = request ?? new RobotCreateRequest();
                var __result = await Factory.Create<IRobotManager>().CreateAsync(Transformers.Robot.MapToSrce(__req.Value)!);
                return Transformers.Robot.MapToDest(__result!)!;
            }, operationType: OperationType.Create, statusCode: HttpStatusCode.Created, alternateStatusCode: null).ExecuteAsync();
        }

        /// <summary>
        /// Updates the <see cref="Robot"/> entity.
        /// </summary>
        /// <param name="request">The <see cref="RobotUpdateRequest"/>.</param>
        /// <param name="context">The <see cref="ServerCallContext context"/>.</param>
        /// <returns>A <see cref="Robot"/>.</returns>
        public override Task<Robot> Update(RobotUpdateRequest request, ServerCallContext context)
        {
            return new GrpcService<Robot>(context, async () =>
            {
                var __req = request ?? new RobotUpdateRequest();
                var __result = await Factory.Create<IRobotManager>().UpdateAsync(Transformers.Robot.MapToSrce(__req.Value)!, Transformers.GuidToStringConverter.ConvertToSrce(__req.Id));
                return Transformers.Robot.MapToDest(__result!)!;
            }, operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null).ExecuteAsync();
        }

        /// <summary>
        /// Deletes the <see cref="Robot"/> entity that matches the selection criteria.
        /// </summary>
        /// <param name="request">The <see cref="RobotDeleteRequest"/>.</param>
        /// <param name="context">The <see cref="ServerCallContext context"/>.</param>
        /// <returns>A <see cref="Google.Protobuf.WellKnownTypes.Empty"/>.</returns>
        public override Task<Google.Protobuf.WellKnownTypes.Empty> Delete(RobotDeleteRequest request, ServerCallContext context)
        {
            return new GrpcService<Google.Protobuf.WellKnownTypes.Empty>(context, async () =>
            {
                var __req = request ?? new RobotDeleteRequest();
                await Factory.Create<IRobotManager>().DeleteAsync(Transformers.GuidToStringConverter.ConvertToSrce(__req.Id));
                return new Google.Protobuf.WellKnownTypes.Empty();
            }, operationType: OperationType.Delete, statusCode: HttpStatusCode.NoContent, alternateStatusCode: null).ExecuteAsync();
        }

        /// <summary>
        /// Gets the <see cref="Robot"/> collection entity that matches the selection criteria.
        /// </summary>
        /// <param name="request">The <see cref="RobotGetByArgsRequest"/>.</param>
        /// <param name="context">The <see cref="ServerCallContext context"/>.</param>
        /// <returns>A <see cref="RobotCollectionResult"/>.</returns>
        public override Task<RobotCollectionResult> GetByArgs(RobotGetByArgsRequest request, ServerCallContext context)
        {
            return new GrpcService<RobotCollectionResult>(context, async () =>
            {
                var __req = request ?? new RobotGetByArgsRequest();
                var __result = await Factory.Create<IRobotManager>().GetByArgsAsync(Transformers.RobotArgs.MapToSrce(__req.Args)!, __req.Paging == null ? new Entities.PagingArgs() : Transformers.PagingArgsToPagingArgsConverter.ConvertToSrce(__req.Paging));
                return Transformers.RobotCollectionResult.MapToDest(__result!)!;
            }, operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent).ExecuteAsync();
        }
    }
}

#nullable restore