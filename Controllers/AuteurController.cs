using NembotKamgueGyldas.Models;
using Microsoft.AspNetCore.Mvc;

namespace NembotKamgueGyldas.Controllers
{
    public class AuteurController : Controller
    {
        private readonly AuteurContext _context;

        public AuteurController(AuteurContext context)
        {
            _context = context;
        }

        // Action : Afficher la liste des auteurs
        public IActionResult Index()
        {
            var auteurs = _context.Auteurs.ToList();
            return View(auteurs);
        }

        // Action : Formulaire de création
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                _context.Auteurs.Add(auteur);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(auteur);
        }

        // Action : Modification - GET
        public IActionResult Edit(int id)
        {
            var auteur = _context.Auteurs.Find(id);
            if (auteur == null)
            {
                return NotFound();
            }
            return View(auteur);
        }

        // Action : Modification - POST
        [HttpPost]
        public IActionResult Edit(Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                _context.Auteurs.Update(auteur);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(auteur);
        }

        // Action : Suppression
        public IActionResult Delete(int id)
        {
            var auteur = _context.Auteurs.Find(id);
            if (auteur != null)
            {
                _context.Auteurs.Remove(auteur);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
