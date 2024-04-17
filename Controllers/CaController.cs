using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis;
using MVC_PH34491.Models;

namespace MVC_PH34491.Controllers
{
    public class CaController : Controller
    {
        NulldContext _context;
        public CaController()
        {
            _context = new NulldContext();
        }
        // GET: CaController
        public ActionResult Index()
        {
            var isK = _context.cas.ToList();
            return View(isK);
        }

        // GET: CaController/Details/5
        public ActionResult Details(string id)
        {
            var KS = _context.cas.Find(id);
            return View(KS);
        }

        // GET: CaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaController/Create
        [HttpPost]
        public ActionResult Create(Ca ca)
        {
            try
            {
               _context.cas.Add(ca);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: CaController/Edit/5
        public ActionResult Edit(string id)
        {
            var KS = _context.cas.Find(id);
            return View(KS);
        }

        // POST: CaController/Edit/5
        [HttpPost]
       
        public ActionResult Edit(Ca ca)
        {
           
            try
            {
                var KS = _context.cas.Find(ca.Id);
                KS.Tuoi = ca.Tuoi;
                KS.Ten = ca.Ten;
                KS.IdDV = ca.IdDV;
                _context.Update(KS);
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: CaController/Delete/5
        public ActionResult Delete(string id)
        {
            var KS = _context.cas.Find(id);
           _context.Remove(KS);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: CaController/Delete/5
        
    }
}
