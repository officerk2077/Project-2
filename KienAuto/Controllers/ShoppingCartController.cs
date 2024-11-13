using KienAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KienAuto.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ShoppingCart GetCart()
        {
            var cart = Session["Cart"] as ShoppingCart;
            if (cart == null)
            {
                cart = new ShoppingCart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public ActionResult Index()
        {
            var cart = GetCart();
            return View(cart.GetItems());
        }

        public ActionResult AddToCart(int id)
        {
            var product = GetProductById(id); // Hàm này lấy sản phẩm theo ID từ cơ sở dữ liệu hoặc danh sách sản phẩm.
            if (product != null)
            {
                GetCart().AddItem(product.Id, product.Name, product.Price, 1);
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int id)
        {
            GetCart().RemoveItem(id);
            return RedirectToAction("Index");
        }

        public ActionResult ClearCart()
        {
            GetCart().ClearCart();
            return RedirectToAction("Index");
        }

        private Product GetProductById(int id)
        {
            // Code để lấy sản phẩm từ cơ sở dữ liệu
            return new Product { Id = id, Name = "Product " + id, Price = 100 };
        }
    }

}