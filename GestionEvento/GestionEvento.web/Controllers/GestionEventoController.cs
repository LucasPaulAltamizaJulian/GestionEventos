using GestionEvento.Dominio.Entidades;
using GestionEvento.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;

namespace GestionEvento.web.Controllers
{
    public class GestionEventoController : Controller
    {
        private readonly GestionEventoDbContext _eventoContexto;

        public GestionEventoController(GestionEventoDbContext eventoContexto)
        {
            _eventoContexto = eventoContexto;
        }

        public IActionResult Index()
        {
            var eventos = _eventoContexto.Eventos.ToList();
            return View(eventos);
        }

        public IActionResult Detalles(int id)
        {
            var evento = _eventoContexto.Eventos.FirstOrDefault(e => e.EventoId == id);
            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Evento evento)
        {
            if (ModelState.IsValid)
            {
                _eventoContexto.Eventos.Add(evento);
                _eventoContexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var evento = _eventoContexto.Eventos.FirstOrDefault(e => e.EventoId == id);
            if (evento == null)
            {
                return NotFound();
            }
            return View(evento);
        }

        [HttpPost]
        public IActionResult Editar(Evento evento)
        {
            if (ModelState.IsValid)
            {
                _eventoContexto.Update(evento);
                _eventoContexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evento);
        }
        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var evento = _eventoContexto.Eventos.FirstOrDefault(e => e.EventoId == id);
            if (evento == null)
            {
                return NotFound();
            }
            _eventoContexto.Eventos.Remove(evento);
            _eventoContexto.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
