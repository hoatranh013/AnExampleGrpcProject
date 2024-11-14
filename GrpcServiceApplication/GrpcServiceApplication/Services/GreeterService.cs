using Grpc.Core;
using GrpcServiceApplication;
using Google.Protobuf.WellKnownTypes;


namespace GrpcServiceApplication.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<ProductResponse> CreateProduct(ProductRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ProductResponse
            {
                CreatedDate = request.CreatedDate,
                OriginalCountry = request.OriginalCountry,
                Price = request.Price,
                ProductName = request.ProductName
            });
        }

        public override async Task<ProductResponse> CreateProductVersionTwo(IAsyncStreamReader<ProductRequest> request, ServerCallContext context)
        {
            var productResponse = new ProductResponse();
            productResponse.Price = 0;
            await foreach (var req in request.ReadAllAsync())
            {
                if (req.Price > productResponse.Price)
                {
                    productResponse.ProductName = req.ProductName;
                    productResponse.OriginalCountry = req.OriginalCountry;
                    productResponse.Price = req.Price;
                    productResponse.CreatedDate = req.CreatedDate;
                }
            }
            return productResponse;
        }

        public override async Task CreateProductVersionThree(ProductRequest request, IServerStreamWriter<ProductResponse> productResponse,ServerCallContext context)
        {
            await productResponse.WriteAsync(new ProductResponse
            {
                ProductName = request.ProductName,
                CreatedDate = request.CreatedDate,
                OriginalCountry = request.OriginalCountry,
                Price = request.Price
            });
            await productResponse.WriteAsync(new ProductResponse
            {
                ProductName = request.ProductName,
                CreatedDate = request.CreatedDate,
                OriginalCountry = request.OriginalCountry,
                Price = request.Price * 2
            });
            await productResponse.WriteAsync(new ProductResponse
            {
                ProductName = request.ProductName,
                CreatedDate = request.CreatedDate,
                OriginalCountry = request.OriginalCountry,
                Price = request.Price * 3
            });
            await productResponse.WriteAsync(new ProductResponse
            {
                ProductName = request.ProductName,
                CreatedDate = request.CreatedDate,
                OriginalCountry = request.OriginalCountry,
                Price = request.Price * 4
            });
            var getResponse = productResponse;
            var logging = getResponse;
        }

        public override async Task CreateProductVersionFour(IAsyncStreamReader<ProductRequest> requests, IServerStreamWriter<ProductResponse> productResponse, ServerCallContext context)
        {
            await foreach (var request in requests.ReadAllAsync())
            {
                await productResponse.WriteAsync(new ProductResponse
                {
                    ProductName = request.ProductName,
                    CreatedDate = request.CreatedDate,
                    OriginalCountry = request.OriginalCountry,
                    Price = request.Price
                });
                await productResponse.WriteAsync(new ProductResponse
                {
                    ProductName = request.ProductName,
                    CreatedDate = request.CreatedDate,
                    OriginalCountry = request.OriginalCountry,
                    Price = request.Price * 2
                });
                await productResponse.WriteAsync(new ProductResponse
                {
                    ProductName = request.ProductName,
                    CreatedDate = request.CreatedDate,
                    OriginalCountry = request.OriginalCountry,
                    Price = request.Price * 3
                });
                await productResponse.WriteAsync(new ProductResponse
                {
                    ProductName = request.ProductName,
                    CreatedDate = request.CreatedDate,
                    OriginalCountry = request.OriginalCountry,
                    Price = request.Price * 4
                });
            }
            var getResponse = productResponse;
            var logging = getResponse;
        }
    }
}
