using KienAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace KienAuto.Areas.Admin.Controllers
{
    public class DanhMucController : Controller
    {
        KienAutoEntities1 db = new KienAutoEntities1();
        // GET: Admin/DanhMuc
        public ActionResult Index()
        {
            var item = db.tb_ProductCategory;
            return View(item);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(tb_ProductCategory model)
        {
            if (ModelState.IsValid)
            {             
                db.tb_ProductCategory.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        public ActionResult Edit(int id)
        {
            var item = db.tb_ProductCategory.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                db.tb_ProductCategory.Attach(model);
                db.Entry(model).Property(x => x.Title).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(model);
            }
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.tb_ProductCategory.Find(id);
            if (item != null)
            {
                db.tb_ProductCategory.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }

}