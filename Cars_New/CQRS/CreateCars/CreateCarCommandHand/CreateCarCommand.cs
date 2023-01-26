using Cars_New.Models;
using Domain.Interface;
using MediatR;

namespace Cars_New.CQRS.CreateCars.CreateCarCommandHand
{
    public class CreateCarCommand : IRequest<Car>
    {
        public int id { get; set; }

        public string img { get; set; }

        public string longDisk { get; set; }

        public string name { get; set; }

        public int year { get; set; }

        public int guarantee { get; set; }

        public int sum { get; set; }

        //Колеса машины
        public string? wheels { get; set; }

        public string? color { get; set; }

        public string Description { get; set; }

        public string city { get; set; }

        //Кузов
        public string Body { get; set; }

        //Коробка передач
        public string Transmission { get; set; }

        //Руль
        public string Steering { get; set; }

        //Номер
        public int phone { get; set; }
    }

    public class CreateCarsHandler : IRequestHandler<CreateCarCommand, Car>
    {
        private readonly IRepository _repos;
        public CreateCarsHandler(IRepository repos)
        {
            _repos = repos;
        }

        public async Task<Car?> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var car = new Car
            {
                id = request.id,
                Body = request.Body,
                city = request.city,
                color = request.color,
                Description = request.Description,
                guarantee = request.guarantee,
                img = request.img,
                longDisk = request.longDisk,
                name = request.name,
                phone = request.phone,
                Steering = request.Steering,
                sum = request.sum,
                Transmission = request.Transmission,
                wheels = request.wheels,
                year = request.year,
            };
            return await _repos.CreteNew(car); 
        }
    }
}
