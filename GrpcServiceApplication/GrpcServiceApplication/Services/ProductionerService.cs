using Grpc.Core;
using GrpcServiceApplication;
using Google.Protobuf.WellKnownTypes;


namespace GrpcServiceApplication.Services
{
    public class ProductionerService : Productioner.ProductionerBase
    {
        private readonly ILogger<ProductionerService> _logger;
        public ProductionerService(ILogger<ProductionerService> logger)
        {
            _logger = logger;
        }

    }
}
