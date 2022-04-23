using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NetworkAcademyFinal.DataContext;
using NetworkAcademyFinal.Entity;

namespace NetworkAcademyFinal.Controllers
{
   
    public class OgrencisController : Controller
    {
        private Context db = new Context();

        // GET: Ogrencis
        public ActionResult Index()
        {
            return View(db.MyEntities.ToList());
        }
        [HttpPost]
        public ActionResult Index(string searchterm) //search extra ekledim
        {
            List<Ogrenci> searchedStudents = new List<Ogrenci>();
           var ogrencis = db.MyEntities.Where(p=> p.Ad.Contains(searchterm));
            if (ogrencis == null)
            {
                return View();
            }
          
            return View(ogrencis);
        }


        // GET: Ogrencis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = db.MyEntities.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // GET: Ogrencis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ogrencis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad,Soyad,TCKimlikNo,Adres,Telefon,AldigiEgitim,BasariDurumu")] Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                db.MyEntities.Add(ogrenci);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ogrenci);
        }

        // GET: Ogrencis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = db.MyEntities.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // POST: Ogrencis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ad,Soyad,TCKimlikNo,Adres,Telefon,AldigiEgitim,BasariDurumu")] Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogrenci).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogrenci);
        }

        // GET: Ogrencis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = db.MyEntities.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        // POST: Ogrencis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogrenci ogrenci = db.MyEntities.Find(id);
            db.MyEntities.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost,ActionName("Search")]
        [ValidateAntiForgeryToken]
      

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
