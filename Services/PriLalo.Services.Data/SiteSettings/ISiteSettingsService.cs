﻿namespace PriLalo.Services.Data.SiteSettings
{
    using System.Threading.Tasks;

    public interface ISiteSettingsService
    {
        decimal GetDeliveryPrice();

        Task SetDeliveryPrice(decimal deliveryPrice);

        int GetDeliveryTime();

        Task SetDeliveryTime(int deliveryTime);

        string GetWorkingHours();

        Task SetWorkingHours(string workingHours);

        string GetMol();

        Task SetMol(string mol);

        string GetCompanyName();

        Task SetCompanyName(string companyName);

        string GetAddres();

        Task SetAddres(string addres);

        string GetBulstat();

        Task SetBulstat(string bulstat);

        string GetHomePageFirstImageTitle();

        Task SetHomePageFirstImageTitle(string homePageFirstImageTitle);

        string GetHomePageSecondImageTitle();

        Task SetHomePageSecondImageTitle(string homePageSecondImageTitle);

        string GetHomePageThirdImageTitle();

        Task SetHomePageThirdImageTitle(string homePageThirdImageTitle);

        string GetHomePageSubImageTitle();

        Task SetHomeHomePageSubImageTitle(string homePageSubImageTitle);
    }
}
