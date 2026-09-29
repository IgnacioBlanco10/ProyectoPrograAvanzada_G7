using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreshShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Shop()
        {
            return View("shop");
        }

        public ActionResult ShopDetail()
        {
            return View("shop-detail");
        }

        public ActionResult Cart()
        {
            return View("cart");
        }

        public ActionResult Checkout()
        {
            return View("checkout");
        }

        public ActionResult MyAccount()
        {
            return View("my-account");
        }

        public ActionResult Wishlist()
        {
            return View("wishlist");
        }

        public ActionResult Gallery()
        {
            return View("gallery");
        }

        public ActionResult ContactUs()
        {
            return View("Contact-us");
        }

        public ActionResult Login()
        {
            return View("login");
        }

        public ActionResult Register()
        {
            return View("register");
        }

        public ActionResult ForgotPassword()
        {
            return View("forgot-password");
        }
    }
}