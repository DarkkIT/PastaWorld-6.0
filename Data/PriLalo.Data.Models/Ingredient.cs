﻿namespace PriLalo.Data.Models
{
    using System.Collections.Generic;

    using PriLalo.Data.Common.Models;

    public class Ingredient : BaseDeletableModel<int>
    {
        public Ingredient()
        {
            this.MealIngredients = new HashSet<MealIngredients>();
        }

        public string Name { get; set; }

        public virtual ICollection<MealIngredients> MealIngredients { get; set; }
    }
}
