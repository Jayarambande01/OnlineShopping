using OnlineShopping.Utility;
using OnlineShopping.WebApp.Models;
using OnlineShopping.WebApp.Services.IServices;
using OnlineShopping.WebApp.Services;

namespace OnlineShopping.WebApp.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string CategoryUrl;

        public ProductService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            CategoryUrl = configuration.GetValue<string>("ServiceUrls:WebAPI");

        }
        public Task<T> CreateAsync<T>(CreateProductDto dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = CategoryUrl + "/api/productAPI"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = CategoryUrl + "/api/productAPI/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = CategoryUrl + "/api/productAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = CategoryUrl + "/api/productAPI/" + id
            });
        }

        public Task<T> UpdateAsync<T>(UpdateProductDto dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = CategoryUrl + "/api/productAPI/" + dto.ProductId
            });
        }
    }
}