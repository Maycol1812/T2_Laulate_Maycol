using Microsoft.AspNetCore.Mvc;
using T2_Laulate_Maycol.Datos;
using T2_Laulate_Maycol.Models;

namespace T2_Laulate_Maycol.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View(lista);
        }

        public IActionResult Peru()
        {
            IEnumerable<DistribuidorPeru> distribuidoresPeru = _db.DistribuidorPE.ToList();
            return View(distribuidoresPeru);
        }

        public IActionResult Mundo()
        {
            IEnumerable<DistribuidorMundo> distribuidoresMundo = _db.DistribuidorMUNDO.ToList();
            return View(distribuidoresMundo);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.Distribuidor.Add(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(distribuidor);

        }

    }
}
