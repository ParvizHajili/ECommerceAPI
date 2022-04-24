using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ECommerceAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Məhsulun adı boş ola bilməz!")
                .MaximumLength(200)
                .MinimumLength(1)
                    .WithMessage("Məhsul adı 200 simvoldan artıq ola bilməz!");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Məhsulun sayı boş ola bilməz!")
                .Must(s => s >= 0)
                    .WithMessage("Məhsul sayı mənfi ədəd ola bilməz!");

            RuleFor(p => p.Price)
               .NotEmpty()
               .NotNull()
                   .WithMessage("Məhsulun qiyməti boş ola bilməz!")
               .Must(s => s >= 0)
                   .WithMessage("Məhsul qiyməti mənfi ədəd ola bilməz!");
        }
    }
}
