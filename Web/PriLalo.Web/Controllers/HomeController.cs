﻿namespace PriLalo.Web.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using PriLalo.Services.Data.News;
    using PriLalo.Web.ViewModels;
    using PriLalo.Web.ViewModels.Cart;
    using PriLalo.Web.ViewModels.News;

    public class HomeController : BaseController
    {
        private readonly INewsService newsService;

        public HomeController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        public IActionResult Index()
        {
            var newses = this.newsService.GetLastThreeNews<NewsViewModel>();
            var viewModel = new NewsListViewModel { NewsList = newses };

            var cartExists = this
               .HttpContext
               .Session
               .TryGetValue("cart", out _);

            if (!cartExists)
            {
                this.InitializeCart();
            }

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        public IActionResult Contacts()
        {
            return this.View();
        }

        public IActionResult Gdpr()
        {
            return this.View("Gdpr");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        private void InitializeCart()
        {
            var cart = new List<CartItemViewModel>();
            var serializedCart = JsonConvert.SerializeObject(cart);
            var cartAsByteArray = Encoding.UTF8.GetBytes(serializedCart);
            this.HttpContext.Session.Set("cart", cartAsByteArray);

            this.ViewBag.cart = cart;
        }
    }
}
