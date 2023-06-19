using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShopping.WebApp.Models;
using OnlineShopping.WebApp.Services.IServices;
using System.Diagnostics;

namespace OnlineShopping.WebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper;
		public HomeController(ICategoryService categoryService, IMapper mapper)
		{
			_categoryService = categoryService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			List<CategoryDto> list = new();

			var response = await _categoryService.GetAllAsync<APIResponse>();
			if (response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<CategoryDto>>(Convert.ToString(response.Result));
			}
			return View(list);
		}
	}
}