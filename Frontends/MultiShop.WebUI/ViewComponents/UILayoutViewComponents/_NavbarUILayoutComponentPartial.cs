using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.CategoryDtos;
using MultiShop.DtoLayer.CatalogDtos.ProductDtos;
<<<<<<< HEAD
using MultiShop.WebUI.Services.BasketServices;
=======
>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
using MultiShop.WebUI.Services.CatalogServices.CategoryServices;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace MultiShop.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;
<<<<<<< HEAD
        private readonly IBasketService _basketService;

        public _NavbarUILayoutComponentPartial(ICategoryService categoryService, IBasketService basketService)
        {
            _categoryService = categoryService;
            _basketService = basketService;
=======

        public _NavbarUILayoutComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();
<<<<<<< HEAD
            var basketItemCount = await _basketService.GetBasket();
            ViewBag.basketItemCount = basketItemCount.BasketItems.Count();
=======
>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
            return View(values);
        }
    }
}
