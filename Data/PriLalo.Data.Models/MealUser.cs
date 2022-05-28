namespace PriLalo.Data.Models
{
    using PriLalo.Data.Common.Models;

    public class MealUser : BaseModel<int>
    {
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int MealId { get; set; }

        public Meal Meal { get; set; }
    }
}
