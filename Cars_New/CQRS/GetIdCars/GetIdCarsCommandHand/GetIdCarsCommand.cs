using Cars_New.Models;
using Domain.Interface;
using MediatR;

namespace Cars_New.CQRS.GetIdCars.GetIdCarsCommandHand
{
    public class GetIdCarsCommand : IRequest<Car>
    {
        public int id { get; set; }
    }
    public class GetIdCarsCommndHandler : IRequestHandler<GetIdCarsCommand, Car>
    {
        private readonly IRepository _repository;
        public GetIdCarsCommndHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Car?> Handle(GetIdCarsCommand request, CancellationToken cancellationToken)
        {
            if (request is not null)
            {
                return await _repository.GetIdCars(request.id);
            }
            return null; 
        }
    }
}
