using Cars_New.Models;
using Domain.Interface;
using MediatR;

namespace Cars_New.CQRS.GetAllCars.GetAllCarsCommandHand
{
    public class GetAllCarsCommand : IRequest<IEnumerable<Car>>
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

    public class GetAllCarsHandler : IRequestHandler<GetAllCarsCommand, IEnumerable<Car>>
    {
        private readonly IRepository _repository;
        private readonly ILogger<GetAllCarsHandler> _logger;
        private const string ThisName = nameof(GetAllCarsHandler);
        public GetAllCarsHandler(IRepository repository, ILogger<GetAllCarsHandler> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IEnumerable<Car>> Handle(GetAllCarsCommand request, CancellationToken cancellationToken)
        {
            var loggergetall = $"{ThisName}/{nameof(Handle)}";
            _logger.LogWarning($"{loggergetall} went to processing");
            return await _repository.GetAllCarsAsync();
        }
    }
}
