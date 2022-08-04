using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    public class Controller2 : Controller
    {
        // GET: Controller2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Controller2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Controller2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controller2/Create
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

        // GET: Controller2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Controller2/Edit/5
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

        // GET: Controller2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Controller2/Delete/5
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
