using Cars_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IRepository : IGenericCars<Car>
    {
        Task<IEnumerable<Basket>> GetAllBasketAsync();
    }
}
