using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoProject.Models;
using System.Data.Entity;

namespace DemoProject.Controllers
{
    public class UserController : Controller
    {
        TestDBEntities db = new TestDBEntities();
        //
        // GET: /User/
        public ActionResult Index()
        {
            var data = db.User_Table;

            return View(data.ToList());
        }

        //
        // GET: /User/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        //
        // GET: /User/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User_Table reg)
        {
            try
            {
               if(ModelState.IsValid)
               {
                   db.User_Table.Add(reg);
                   db.SaveChanges();
               }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /User/Edit/5
        public ActionResult Edit(int id)
        {
            var data=db.User_Table.Find(id);
            return View(data);
        }

        //
        // POST: /User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User_Table data)
        {
            try
            {
                // TODO: Add update logic here
               if(ModelState.IsValid)
               {
                   db.Entry(data).State = EntityState.Modified;
                   db.SaveChanges();
               }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User_Table data)
        {
            try
            {
                // TODO: Add delete logic here
                var del = db.User_Table.Find(id);
                if (del != null)
                    db.User_Table.Remove(del);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
