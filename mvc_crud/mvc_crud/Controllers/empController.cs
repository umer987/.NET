using mvc_crud.Models;
using System.Linq;
using System.Web.Mvc;

namespace mvc_crud.Controllers
{
    public class empController : Controller
    {
        string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;TrustServerCertificate=True";

        // GET: emp
        public ActionResult Index()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = from s in db.doctors select s;
            return View(res);
        }

        // GET: emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: emp/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(doctor d)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            db.doctors.InsertOnSubmit(d);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        // GET: emp/Edit/5
        public ActionResult Edit(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var doctor = db.doctors.SingleOrDefault(x => x.id == id);
            return View(doctor);
        }

        // POST: emp/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(doctor d)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var doc = db.doctors.SingleOrDefault(x => x.id == d.id);

            doc.doc_name = d.doc_name;
            doc.doc_speciality = d.doc_speciality;
            doc.doc_age = d.doc_age;

            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        // GET: emp/Delete/5
        public ActionResult Delete(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var doctor = db.doctors.SingleOrDefault(x => x.id == id);
            return View(doctor);
        }

        // POST: emp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var doctor = db.doctors.SingleOrDefault(x => x.id == id);
            db.doctors.DeleteOnSubmit(doctor);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }
    }
}
