using pracmvcc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pracmvcc.Controllers
{
    public class cntController : Controller
    {
        string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=contacts;Integrated Security=True;TrustServerCertificate=True";
        
        // GET: cnt
        public ActionResult Index()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = from s in db.contacts select s;

            return View(res);
        }

        // GET: cnt/Details/5
        public ActionResult Details(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.contacts.SingleOrDefault(x => x.id == id);
            return View(res);
        }

        // GET: cnt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cnt/Create
        [HttpPost]
        public ActionResult Create(contact c)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                db.contacts.InsertOnSubmit(c);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: cnt/Edit/5
        public ActionResult Edit(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.contacts.SingleOrDefault(x => x.id == id);
            return View(res);
        }

        // POST: cnt/Edit/5
        [HttpPost]
        public ActionResult Edit(contact c)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                var res = db.contacts.SingleOrDefault(x => x.id == c.id);
                res.fname = c.fname;
                res.lname = c.lname;
                res.number = c.number;
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: cnt/Delete/5
        public ActionResult Delete(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = db.contacts.SingleOrDefault(x => x.id == id);
            return View(res);
        }

        // POST: cnt/Delete/5
        [HttpPost]
        public ActionResult Delete(contact c)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(con);
                var res = db.contacts.SingleOrDefault(x=> x.id == c.id);
                db.contacts.DeleteOnSubmit(res);
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
