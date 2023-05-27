using FlashFood_Original.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlashFood_Original.Controllers
{
    public class CARDAPIOController : Controller
    {
        private readonly Contexto Db;

        public CARDAPIOController(Contexto contexto)

        {
            Db = contexto;
        }


        public IActionResult Produtos()
        {
            return View(Db.CARDAPIO.ToList());
        }
        /*
        public ActionResult Index()
        {
            return View(Db.CARDAPIO.ToList());
        }

        // GET: CARDAPIOController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CARDAPIOController/Create
        public ActionResult Create()
        {
            return View();
        }*/

        // POST: CARDAPIOController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CARDAPIO collection)
        {
            try
            {
                Db.CARDAPIO.Add(collection);
                Db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CARDAPIOController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CARDAPIOController/Edit/5
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

        // GET: CARDAPIOController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CARDAPIOController/Delete/5
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