namespace PriLalo.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using PriLalo.Data.Models;
    using PriLalo.Services.Data;
    using PriLalo.Web.ViewModels.Settings;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using PriLalo.Common;
    using PriLalo.Services.Data;
    using PriLalo.Data.Common.Repositories;
    using PriLalo.Data.Models;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    public class SettingsController : BaseController
    {
        private readonly ISettingsService settingsService;

        private readonly IDeletableEntityRepository<Setting> repository;

        public SettingsController(ISettingsService settingsService, IDeletableEntityRepository<Setting> repository)
        {
            this.settingsService = settingsService;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var settings = this.settingsService.GetAll<SettingViewModel>();
            var model = new SettingsListViewModel { Settings = settings };
            return this.View(model);
        }

        public async Task<IActionResult> InsertSetting()
        {
            var random = new Random();
            var setting = new Setting { Name = $"Name_{random.Next()}", Value = $"Value_{random.Next()}" };

            await this.repository.AddAsync(setting);
            await this.repository.SaveChangesAsync();

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
