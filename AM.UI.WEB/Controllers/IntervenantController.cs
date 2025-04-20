using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.UI.WEB.Controllers
{
    public class IntervenantController : Controller
    {
        private readonly ITraitement _t;


        private readonly IBulletin _p;


        private readonly IntervenantInterface _i;

        public IntervenantController(ITraitement t, IBulletin p, IntervenantInterface i)
        {
            _t = t;
            _p = p;
            _i = i;
        }

        // GET: IntervenantController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IntervenantController/Details/5
        public ActionResult Details(int id)
        {
            return View(_i.GetById(id));
        }

        // GET: IntervenantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IntervenantController/Create
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

        // GET: IntervenantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IntervenantController/Edit/5
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

        // GET: IntervenantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IntervenantController/Delete/5
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
