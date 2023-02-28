using Example.Service;
using Grpc.Core;

namespace GrpcSwaggerExample;

public class Service : GrpcService.GrpcServiceBase
{
    public override Task<GetItemResponse> GetItem(GetItemRequest request, ServerCallContext context)
    {
        return Task.FromResult(new GetItemResponse(){ItemId = request.ItemId});
    }

    public override Task<GetItemResponse> GetItemRouting(GetItemRequest request, ServerCallContext context)
    {
        return Task.FromResult(new GetItemResponse(){ItemId = request.ItemId});
    }

    public override Task<GetItemResponse> PostItem(GetItemRequest request, ServerCallContext context)
    {
        return Task.FromResult(new GetItemResponse(){ItemId = request.ItemId});
    }
}