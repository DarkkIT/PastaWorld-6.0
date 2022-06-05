namespace PriLalo.Web.ViewModels.SiteSetting
{
    using PriLalo.Data.Models;
    using PriLalo.Services.Mapping;

    public class SiteSettingViewModel : IMapFrom<SiteSetting>
    {
        public string HomePageImageTitle { get; set; }

        public string HomePageSecondImageTitle { get; set; }

        public string HomePageThirdImageTitle { get; set; }

        public string HomePageSubImageTitle { get; set; }

        public decimal PriceDelivery { get; set; }

        public string WorkingHours { get; set; }

        public int DeliveryTime { get; set; }

        public string Address { get; set; }

        public string Mol { get; set; }

        public string Bulstat { get; set; }

        public string CompanyName { get; set; }
    }
}
