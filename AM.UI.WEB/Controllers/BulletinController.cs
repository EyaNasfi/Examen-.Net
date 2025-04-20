using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.UI.WEB.Controllers
{
    public class BulletinController : Controller
    {
        private readonly ITraitement _t;


        private readonly IBulletin _p;


        private readonly IntervenantInterface _i;

        public BulletinController(ITraitement t, IBulletin p, IntervenantInterface i)
        {
            _t = t;
            _p = p;
            _i = i;
        }
        // GET: BulletinController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BulletinController/Details/5
        public ActionResult Details(int id)
        {
            return View(_p.GetById(id));
        }

        // GET: BulletinController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BulletinController/Create
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

        // GET: BulletinController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BulletinController/Edit/5
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

        // GET: BulletinController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BulletinController/Delete/5
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
