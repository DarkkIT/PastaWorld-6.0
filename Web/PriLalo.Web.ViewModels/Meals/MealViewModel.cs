namespace PriLalo.Web.ViewModels.Meals
{
    using System;

    using AutoMapper;
    using PriLalo.Data.Models;
    using PriLalo.Services.Mapping;

    public class MealViewModel : IMapFrom<Meal>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public bool IsTop { get; set; }

        public DateTime NewsDate { get; set; }

        public string Publisher { get; set; }

        public string ImageName { get; set; }

        public string MainImagePath => "/images/meals/" + this.ImageName + ".jpg";

        public byte[] Image { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeletedOn { get; set; }

    }
}
