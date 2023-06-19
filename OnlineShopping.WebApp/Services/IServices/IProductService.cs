using OnlineShopping.WebApp.Models;

namespace OnlineShopping.WebApp.Services.IServices
{
    public interface IProductService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(CreateProductDto dto);
        Task<T> UpdateAsync<T>(UpdateProductDto dto);
        Task<T> DeleteAsync<T>(int id);
    }
}