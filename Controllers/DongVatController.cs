using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_PH34491.Models;

namespace MVC_PH34491.Controllers
{
    public class DongVatController : Controller
    {
        NulldContext _context;
        public DongVatController()
        {
            _context = new NulldContext();
        }
        // GET: DongVatController
        public ActionResult Index()
        {
            var de = _context.DongVats.ToList();
            return View(de);
        }

        // GET: DongVatController/Details/5
        public ActionResult Details(string id)
        {
            var de = _context.DongVats.Find(id);
            return View(de);
        }

        // GET: DongVatController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DongVatController/Create
        [HttpPost]
       
        public ActionResult Create(DongVat dongVat)
        {
            try
            {
                _context.Add(dongVat);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: DongVatController/Edit/5
        public ActionResult Edit(string id)
        {

            var de = _context.DongVats.Find(id);
            return View(de);
        }

        // POST: DongVatController/Edit/5
        [HttpPost]
       
        public ActionResult Edit(DongVat dongVat)
        {

            try
            {
                var KS = _context.DongVats.Find(dongVat.Id);
                KS.Ho = dongVat.Ho;
                KS.NoiSong = dongVat.NoiSong;
                KS.ThucAn = dongVat.ThucAn;
              
                _context.Update(KS);
                _context.SaveChanges();

                return RedirectToAction("Index");
              
            }
            catch
            {
                return View();
            }
        }

        // GET: DongVatController/Delete/5
        public ActionResult Delete(string id)
        {
            var KS = _context.DongVats.Find(id);
            _context.Remove(KS);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: DongVatController/Delete/5
       
    }
}
