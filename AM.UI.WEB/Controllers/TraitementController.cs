using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{
    public class TraitementController : Controller
    {
        private readonly ITraitement _t;


        private readonly IBulletin _p;


        private readonly IntervenantInterface _i;

        public TraitementController(ITraitement t, IBulletin p, IntervenantInterface i)
        {
            _t = t;
            _p = p;
            _i = i;
        }

        // GET: TraitementController
        public ActionResult Index()
        {
            return View(_t.GetAll().OrderByDescending(p=>p.DateTraitement).ToList());
        }

        // GET: TraitementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TraitementController/Create
        public ActionResult Create()
        {
            ViewBag.Bull = new SelectList(_p.GetAll().ToList(),
            "BulletinSoinId", "Numero");
            ViewBag.Int= new SelectList(_i.GetAll().ToList(),
            "IntervenantId", "Prenom");
            return View();
        }

        // POST: TraitementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Traitement t)
        {
            try
            {
                _t.Add(t);
                _t.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraitementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TraitementController/Edit/5
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

        // GET: TraitementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TraitementController/Delete/5
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
