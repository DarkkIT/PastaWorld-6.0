namespace PriLalo.Web.ViewModels.Attributes
{
    using System.ComponentModel.DataAnnotations;

    using PriLalo.Web.ViewModels.Orders;

    public class CheckBoxRequired : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var order = (OrderPaymentViewModel)validationContext.ObjectInstance;

            if (order.IsAgreedTermsAndConditions == false)
            {
                return new ValidationResult(this.ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
