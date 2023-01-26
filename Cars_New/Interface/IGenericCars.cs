using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IGenericCars<T> where T : class
    {
        Task<IEnumerable<T>> GetAllCarsAsync();
        Task<int> Remove(int id);
        Task<T> GetIdCars(int id);
        Task<T> CreteNew(T car);
    }
}
