using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETcoreMVC.Controllers
{
    public class Read_Write_Controller : Controller
    {
        // GET: Read_Write_Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Read_Write_Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Read_Write_Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Read_Write_Controller/Create
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

        // GET: Read_Write_Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Read_Write_Controller/Edit/5
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

        // GET: Read_Write_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Read_Write_Controller/Delete/5
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
