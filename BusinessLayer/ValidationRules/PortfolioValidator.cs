using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat bilgisi boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı minumum 5 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Proje adı fazla 50 karakter olmalıdır");

        }
    }
}
