using Cars_New.DATA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cars_New.Controllers
{
    public class BusketController : Controller
    {
        private readonly ILogger<BusketController> _logger;
        private readonly CarDbContext _db;

        public BusketController(ILogger<BusketController> logger, CarDbContext carDb)
        {
            _logger = logger;
            _db = carDb;
        }

        // GET: BusketController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BusketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BusketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BusketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusketController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
