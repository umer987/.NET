using house_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace house_crud.Controllers
{
    public class houseController : Controller
    {
        string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=housemanagment;Integrated Security=True;TrustServerCertificate=True";
        // GET: house
        public ActionResult Index()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var respone = from h in db.houses select h;
            return View(respone);
        }

        // GET: house/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: house/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: house/Create
        [HttpPost]
        public ActionResult Create(house h)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                db.houses.InsertOnSubmit(h);
                db.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: house/Edit/5
        public ActionResult Edit(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var house = db.houses.SingleOrDefault(x => x.house_number == id);
            return View(house);
        }

        // POST: house/Edit/5
        [HttpPost]
        public ActionResult Edit(house h)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                var house = db.houses.SingleOrDefault(x => x.house_number == h.house_number);
                house.owner_name= h.owner_name;
                house.house_address=h.house_address;
                house.nearest_place = h.nearest_place;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: house/Delete/5
        public ActionResult Delete(int id)

        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var house = db.houses.SingleOrDefault(x => x.house_number == id);
            return View(house);
        }

        // POST: house/Delete/5
        [HttpPost , ActionName("Delete")]
        public ActionResult Deletecnfrm(int id)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                var house = db.houses.SingleOrDefault(x => x.house_number == id);
                db.houses.DeleteOnSubmit(house);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
