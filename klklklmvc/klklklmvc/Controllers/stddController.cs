using klklklmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace klklklmvc.Controllers
{
    public class stddController : Controller
    {
        string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;TrustServerCertificate=True";
        // GET: stdd
        public ActionResult Index()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = from s in db.students_records select s;

            return View(res);
        }

        // GET: stdd/Details/5
        public ActionResult Details(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.students_records.SingleOrDefault(x => x.student_id ==id);
            return View(res);
        }

        // GET: stdd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: stdd/Create
        [HttpPost]
        public ActionResult Create(students_record s)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                db.students_records.InsertOnSubmit(s);
                db.SubmitChanges ();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: stdd/Edit/5
        public ActionResult Edit(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.students_records.SingleOrDefault(x=> x.student_id == id);
           
            return View(res);
        }

        // POST: stdd/Edit/5
        [HttpPost]
        public ActionResult Edit(students_record s)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                var res = db.students_records.SingleOrDefault(x => x.student_id == s.student_id);
                res.student_name= s.student_name;
                res.father_name= s.father_name;
                res.department = s.department;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: stdd/Delete/5
        public ActionResult Delete(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.students_records.SingleOrDefault(x => x.student_id == id);

            return View(res);
        }

        // POST: stdd/Delete/5
        [HttpPost , ActionName("Delete")]
        public ActionResult Deletex(int id)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                var res = db.students_records.SingleOrDefault(x => x.student_id == id);
                db.students_records.DeleteOnSubmit(res);
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
