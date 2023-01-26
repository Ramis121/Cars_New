using Cars_New.CQRS.GetAllCars.GetAllCarsCommandHand;
using Cars_New.Models;
using FluentValidation;

namespace Cars_New.CQRS.GetAllCars.GetAllCarsValid
{
    public class GetAllCarRuleFore : AbstractValidator<GetAllCarsCommand> 
    {
        public GetAllCarRuleFore()
        {
            RuleFor(a => a.id)
                .NotEmpty().WithMessage("ID empty");
        }
    }
}
