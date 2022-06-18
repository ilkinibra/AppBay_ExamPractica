using AppBay_BackEnd.Models;
using FluentValidation;

namespace AppBay_BackEnd.Validators
{
    public class CardValidation:AbstractValidator<Card>
    {
        public CardValidation()
        {
            RuleFor(c => c.IconPath).NotNull().NotEmpty();
            RuleFor(c => c.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(c => c.Description).NotEmpty().NotEmpty().MaximumLength(100);
        }
    }
}
