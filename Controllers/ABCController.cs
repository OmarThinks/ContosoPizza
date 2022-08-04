using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    public class ABCController : Controller
    {
        // GET: ABCController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ABCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ABCController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ABCController/Create
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

        // GET: ABCController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ABCController/Edit/5
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

        // GET: ABCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ABCController/Delete/5
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
