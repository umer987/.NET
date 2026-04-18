using emp_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emp_mvc.Controllers
{
    public class empController : Controller
    {
        string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=empmvc;Integrated Security=True;TrustServerCertificate=True";
        // GET: emp
        public ActionResult Index()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = from s in db.emp_recs select s;

            return View(res);
        }

        // GET: emp/Details/5
        public ActionResult Details(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.emp_recs.SingleOrDefault(x => x.id == id);
            return View(res);
        }

        // GET: emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: emp/Create
        [HttpPost]
        public ActionResult Create(emp_rec e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                db.emp_recs.InsertOnSubmit(e);
                db.SubmitChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: emp/Edit/5
        public ActionResult Edit(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.emp_recs.SingleOrDefault(x => x.id == id);
            return View(res);
        }

        // POST: emp/Edit/5
        [HttpPost]
        public ActionResult Edit(emp_rec e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                var res = db.emp_recs.SingleOrDefault(x => x.id == e.id);
                res.emp_name = e.emp_name;
                res.emp_dept = e.emp_dept;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: emp/Delete/5
        public ActionResult Delete(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.emp_recs.SingleOrDefault(x => x.id == id);
          
            return View(res);
        }

        // POST: emp/Delete/5
        [HttpPost]
        public ActionResult Delete(emp_rec e)
        {
            try
            {
               DataClasses1DataContext db = new DataClasses1DataContext(con);
                var res = db.emp_recs.SingleOrDefault(x => x.id == e.id);
                db.emp_recs.DeleteOnSubmit(res);
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
