using Cars_New.DATA;
using Cars_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Diagnostics;
using Cars_New.CQRS.GetAllCars.GetAllCarsCommandHand;
using Cars_New.CQRS.DeleteCars.DeleteCarsCommandHand;
using Cars_New.CQRS.GetIdCars.GetIdCarsCommandHand;
using Cars_New.CQRS.CreateCars.CreateCarCommandHand;
using Cars_New.CQRS.GetAllBasket.GetAllBasketCommandHand;

namespace Cars_New.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarDbContext _db;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, CarDbContext carDb, IMediator mediator)
        {
            _logger = logger;
            _db = carDb
                ?? throw new ArgumentException(nameof(carDb));
            _mediator = mediator
                ?? throw new ArgumentException(nameof(mediator));
            //Basket basket = new Basket();
            //basket.guarantee = 10;
            //basket.Body = "кроссовер";
            //basket.city = "Алматы";
            //basket.color = "Blue";
            //basket.Description = "Авто в наличии в нашем шоу-руме «E-CAR-CN» по адресу: г. Алматы, ул. Жандосова 39/3." +
            //"Топовая комплектация: Запас хода на электротяге (км) — 480 Мощность электромотора (kW)" +
            //"120 Максимальный крутящий момент (Nm) — 280 Емкость батареи (kWh) — 61.3" +
            //"Привезём любой электромобиль на заказ по самым низким ценам";
            //basket.img = "https://alakcell-photos-kl.kcdn.kz/webp/ac/acdfb423-5533-4464-88f8-979f2604e7cd/20-750x470.webp";
            //basket.longDisk = "Машина не бита не крашина";
            //basket.name = "Honda M-NV";
            //basket.phone = 870759952;
            //basket.Steering = "слева";
            //basket.sum = 15500000;
            //basket.Transmission = "автомат";
            //basket.wheels = "Обычные";
            //basket.year = 2022;

            //List<Car> cars = new List<Car>();
            //cars.Add(new Car
            //{
            //    guarantee = 10,
            //    Body = "кроссовер",
            //    city = "Алматы",
            //    color = "Blue",
            //    Description = "Авто в наличии в нашем шоу-руме «E-CAR-CN» по адресу: г. Алматы, ул. Жандосова 39/3." +
            //    "Топовая комплектация: Запас хода на электротяге (км) — 480 Мощность электромотора (kW)" +
            //    "120 Максимальный крутящий момент (Nm) — 280 Емкость батареи (kWh) — 61.3" +
            //    "Привезём любой электромобиль на заказ по самым низким ценам",
            //    img = "https://alakcell-photos-kl.kcdn.kz/webp/ac/acdfb423-5533-4464-88f8-979f2604e7cd/20-750x470.webp",
            //    longDisk = "Машина не бита не крашина",
            //    name = "Honda M-NV",
            //    phone = 870759952,
            //    Steering = "слева",
            //    sum = 15500000,
            //    Transmission = "автомат",
            //    wheels = "Обычные",
            //    year = 2022,
            //});
            //_db.cars.AddRange(cars);
            //_db.SaveChanges();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Cars()
        {
            return View(await _mediator.Send(new GetAllCarsCommand()));
        }

        [HttpGet]
        public IActionResult Buy() => View(); 

        [HttpPost]
        public async Task<IActionResult> Buy(Basket basket)
        {
            if (basket is not null)
            {
                await _db.baskets.AddAsync(basket); 
                await _db.SaveChangesAsync();
                return RedirectToAction("GetBasketCars");
            }
            return BadRequest();
        }

        [HttpGet]
        [ActionName("Create")]
        public async Task<IActionResult> Create_Cars()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCarCommand createCar)
        {
            return createCar is null ? BadRequest() : Ok(await _mediator.Send(createCar));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCarCommand { id = id });
            return RedirectToAction("Cars");
        }

        [HttpGet]
        public async Task<IActionResult> GetBasketCars()
        {
            return View(await _mediator.Send(new GetAllBasketCommand ()));
        }

        [HttpGet]
        public async Task<IActionResult> GetIdCars(int id)
        {
            return View(await _mediator.Send(new GetIdCarsCommand { id = id }));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}