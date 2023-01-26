using Cars_New.DATA;
using Cars_New.Models;
using Domain.ApiException;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;

namespace Cars_New.Service
{
    public class RepositoryCars : IRepository
    {
        private readonly CarDbContext _db;
        private readonly ILogger<RepositoryCars> _logger;
        private const string ThisName = nameof(RepositoryCars);
        public RepositoryCars(CarDbContext db, ILogger<RepositoryCars> logger)
        {
            _db = db 
                ?? throw new ArgumentException(nameof(_db));
            _logger = logger
                 ?? throw new ArgumentException(nameof(_logger));
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            var loggergetall = $"{ThisName}/{nameof(GetAllCarsAsync)}";
            _logger.LogWarning($"{loggergetall} went to processing");
            try
            {
                _logger.LogInformation($"The database processes the data {loggergetall}");
                return await Task.FromResult(await _db.cars.ToListAsync());
            }
            catch (ApiException exc)
            {
                _logger.LogError("Database not found");
                throw new ApiException($"{exc.Message} database not found");
            }
        }

        public async Task<int> Remove(int id)
        {
            var logdeletecar = $"{ThisName}/{nameof(Remove)}";
            _logger.LogWarning($"Cars remove {logdeletecar}");
            var res = await _db.cars.FindAsync(id);
            if (res is not null)
            {
                _db.cars.Remove(res);
                await _db.SaveChangesAsync();
                return await Task.FromResult(id);
            }
            else
                _logger.LogError($"{logdeletecar} {res} is null");
            return id;
        }

        public async Task<Car?> GetIdCars(int id)
        {
            var loggetid = $"{ThisName}/{nameof(GetIdCars)}";
            _logger.LogWarning($"{loggetid} processing");
            var res = await _db.cars.FindAsync(id);
            if (res is not null)
            {
                return await Task.FromResult(res);
            }
            return null; 
        }

        public async Task<Car?> CreteNew(Car car)
        {
            var logcreatecarnew = $"{ThisName}/{nameof(CreteNew)}";
            if (car is not null)
            {
                await _db.cars.AddAsync(car);
                await _db.SaveChangesAsync();
                _logger.LogInformation($"car added to showroom {logcreatecarnew}");
                return await Task.FromResult(car);
            }
            return null;
        }

        public async Task<IEnumerable<Basket>> GetAllBasketAsync()
        {
            var loggetbasketasync = $"{ThisName}/{nameof(GetAllBasketAsync)}";
            _logger.LogWarning($"method {loggetbasketasync} started working");
            try
            {
                _logger.LogInformation($"method {loggetbasketasync} started reading data");
                return await Task.FromResult(await _db.baskets.ToListAsync());
            }
            catch (Exception)
            {
                _logger.LogError($"method {loggetbasketasync} stopped reading data");
                throw new ApiException("data was not delivered from the database");
            }
        }
    }
}
