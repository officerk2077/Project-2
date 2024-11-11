using KienAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KienAuto.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        KienAutoEntities1 db = new KienAutoEntities1();
        // GET: Admin/Product
        public ActionResult Index()
        {
            var items = db.tb_Product.ToList();
            return View(items);
        }
        public ActionResult Add()
        {
            ViewBag.danhmuc = new SelectList(db.tb_ProductCategory, "id", "Title");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(tb_Product model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                db.tb_Product.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                // Repopulate dropdown if model validation fails
                ViewBag.danhmuc = new SelectList(db.tb_ProductCategory, "id", "Title");
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
          
                var item = db.tb_Product.Find(id);
                if (item == null)
                {
                    ModelState.AddModelError("", "Không tìm thấy sản phẩm");
                }

            ViewBag.danhmuc = new SelectList(db.tb_ProductCategory, "id", "Title");
            return View(item);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_Product model)
        {
            if (ModelState.IsValid)
            {
                var existingItem = db.tb_Product.Find(model.id);
                if (existingItem != null)
                {
                    // Update properties
                    existingItem.Title = model.Title;
                    existingItem.ProductCategoryID = model.ProductCategoryID;
                    existingItem.Quantity = model.Quantity;
                    existingItem.Price = model.Price;
                    existingItem.Detail = model.Detail;
                    existingItem.PriceSale = model.PriceSale;
                    
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return HttpNotFound();
            }

            // Repopulate dropdown if validation fails
            ViewBag.danhmuc = new SelectList(db.tb_ProductCategory, "id", "Title");
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.tb_Product.Find(id);
            if (item != null)
            {
                db.tb_Product.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}