using OnlineShopping.Utility;
using OnlineShopping.WebApp.Models;
using OnlineShopping.WebApp.Services.IServices;
using OnlineShopping.WebApp.Services;

namespace OnlineShopping.WebApp.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string CategoryUrl;

        public CategoryService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            CategoryUrl = configuration.GetValue<string>("ServiceUrls:WebAPI");

        }
        public Task<T> CreateAsync<T>(CategoryDto dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = CategoryUrl + "/api/categoryAPI"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = CategoryUrl + "/api/categoryAPI/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = CategoryUrl + "/api/categoryAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = CategoryUrl + "/api/categoryAPI/" + id
            });
        }

        public Task<T> UpdateAsync<T>(CategoryDto dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = CategoryUrl + "/api/categoryAPI/" + dto.CategoryId
            });
        }
    }
}