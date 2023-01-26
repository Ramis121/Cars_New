using Domain.Interface;
using MediatR;

namespace Cars_New.CQRS.DeleteCars.DeleteCarsCommandHand
{
    public class DeleteCarCommand : IRequest<int>
    {
        public int id { get; set; }
    }

    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, int>
    {
        private readonly IRepository _repository;
        private readonly ILogger<DeleteCarCommandHandler> _logger;
        private const string ThisName = nameof(DeleteCarCommandHandler);
        public DeleteCarCommandHandler(IRepository repository, ILogger<DeleteCarCommandHandler> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<int> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var logdeletecar = $"{ThisName}/{nameof(Handle)}";
            _logger.LogInformation(logdeletecar);

            await _repository.Remove(request.id);
            return request.id;
        }
    }
}
