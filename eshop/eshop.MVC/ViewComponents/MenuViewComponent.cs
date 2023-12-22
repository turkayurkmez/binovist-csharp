using eshop.Application;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public MenuViewComponent(ICategoryService categoryService)
        {

            this.categoryService = categoryService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.GetCategoriesAsync();
            return View(categories);
        }

    }
}
