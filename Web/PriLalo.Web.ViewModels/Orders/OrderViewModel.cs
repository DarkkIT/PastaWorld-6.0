﻿namespace PriLalo.Web.ViewModels.Orders
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using PriLalo.Data.Models;
    using PriLalo.Services.Mapping;
    using PriLalo.Web.ViewModels.Cart;

    public class OrderViewModel : IMapFrom<Order>
    {
        public int Id { get; set; }

        [Display(Name = OrderConstants.Address)]
        [Required(ErrorMessage="Моля, въведете адрес!")]
        public string Address { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal MealsPrice { get; set; }

        public string Status { get; set; }

        [Display(Name = OrderConstants.PhoneNumber)]
        [Required(ErrorMessage = "Телефонния номер е задължително поле за попълване!")]
        [Phone(ErrorMessage = "Моля, въведете коректен телефонен номер за връзка!")]
        public string PhoneNumber { get; set; }

        [Display(Name = OrderConstants.FirstName)]
        [Required(ErrorMessage = "Моля, въведете собствено име!")]
        public string FirstName { get; set; }

        [Display(Name = OrderConstants.FamilyName)]
        [Required(ErrorMessage = "Моля, въведете фамилно име!")]
        public string FamilyName { get; set; }

        [Display(Name = OrderConstants.Email)]
        [Required(ErrorMessage = "Моля, въведете email!")]
        public string Email { get; set; }

        public string CliendId { get; set; }

        public List<string> Meals { get; set; }

        public ICollection<CartItemViewModel> Items { get; set; }
    }
}
