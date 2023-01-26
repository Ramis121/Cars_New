using Cars_New.CQRS.DeleteCars.DeleteCarsCommandHand;
using FluentValidation;

namespace Cars_New.CQRS.DeleteCars.DeleteCarsValid
{
    public class DeleteCarsRuleFor : AbstractValidator<DeleteCarCommand>
    {
        public DeleteCarsRuleFor()
        {
            RuleFor(a => a.id)
                .Empty().WithMessage("ID empty");
        }
    }
}
