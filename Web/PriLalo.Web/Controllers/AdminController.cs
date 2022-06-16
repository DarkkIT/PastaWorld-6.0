namespace PriLalo.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using PriLalo.Common;
    using PriLalo.Services.Data.Meal;
    using PriLalo.Services.Data.News;
    using PriLalo.Web.ViewModels.Admins;
    using PriLalo.Web.ViewModels.Meals;
    using PriLalo.Web.ViewModels.News;

    [Authorize(Roles =
        GlobalConstants.AdministratorRoleName + "," +
        GlobalConstants.ChefRoleName + "," +
        GlobalConstants.BartenderRoleName + "," +
        GlobalConstants.DeliveryManRoleName)]
    public class AdminController : BaseController
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly INewsService newsService;
        private readonly IMealService mealService;

        public AdminController(IWebHostEnvironment webHostEnvironment, INewsService newsService, IMealService mealService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.newsService = newsService;
            this.mealService = mealService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult AddNews()
        {
            return this.View();
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult AddMeal()
        {
            return this.View();
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> MakeTop(int id, string name)
        {
            await this.mealService.MakeTop(id);

            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, name);
            var viewModel = new MealListViewModel { TypeName = name, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult Success()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> AddNews(AddNewsInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            if (input.Image != null && input.Image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    input.Image.CopyTo(ms);
                    input.ImageAsByteArray = ms.ToArray();
                }
            }

            await this.newsService.AddNewsAsync(input);

            return this.RedirectToAction(nameof(this.Success));
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> AddMeal(AddMealInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            if (input.Image != null && input.Image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    input.Image.CopyTo(ms);
                    input.ImageAsByteArray = ms.ToArray();
                }
            }

            await this.mealService.AddMealAsync(input);

            return this.RedirectToAction(nameof(this.Success));
        }

        public IActionResult AllNews()
        {
            var newses = this.newsService.GetAllNewsWithDeleted<NewsViewModel>(1, 1000);
            var viewModel = new NewsListViewModel { NewsList = newses, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult AllMeals(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult GetMain(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult GetPasta(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult GetPizza(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult GetSalads(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult GetDrinks(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult GetDesserts(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        public IActionResult GetKids(string adminPageName)
        {
            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, adminPageName);
            var viewModel = new MealListViewModel { TypeName = adminPageName, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.View(viewModel);
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult EditNews(int id)
        {
            var viewModel = this.newsService.GetById<NewsViewModel>(id);

            return this.View(viewModel);
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public IActionResult EditMeal(int id)
        {
            var viewModel = this.mealService.GetById<MealViewModel>(id);

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> EditNews(EditNewsInputModel input, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.newsService.EditNewsAsync(input, id);

            return this.RedirectToAction(nameof(this.Success));
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> EditMeal(EditMealInputModel input, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.mealService.EditMealAsync(input, id);

            return this.RedirectToAction(nameof(this.Success));
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> DeleteNews(int id)
        {
            await this.newsService.DeleteNews(id);

            return this.RedirectToAction(nameof(this.AllNews));
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName + "," +
        GlobalConstants.ChefRoleName)]
        public async Task<IActionResult> DeleteMeal(int id, string name)
        {
            await this.mealService.DeleteMeal(id);

            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, name);
            var viewModel = new MealListViewModel { TypeName = name, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.RedirectToAction(nameof(this.AllMeals), new { adminPageName = name });
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<IActionResult> UnDeleteNews(int id)
        {
            await this.newsService.UnDeleteNews(id);

            return this.RedirectToAction(nameof(this.AllNews));
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName + "," +
        GlobalConstants.ChefRoleName)]
        public async Task<IActionResult> UnDeleteMeal(int id, string name)
        {
            await this.mealService.UnDeleteMeal(id);

            var meals = this.mealService.GetAllMealWithDeleted<MealViewModel>(1, 1000, name);
            var viewModel = new MealListViewModel { TypeName = name, MealList = meals, PageNumber = 1, MotorBikeCount = this.newsService.GetCount(), ItemsPerPage = GlobalConstants.ItemsPerPage };

            return this.RedirectToAction(nameof(this.AllMeals), new { adminPageName = name });
        }
    }
}
