using Learn.Code;
using Learn.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            SessionHelper.ClearSession();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            //goi method truy van DB để kiểm tra thông số đăng nhập có đúng hay ko, từ project library Models
            var result = new AccountModel().Login(model.userName, model.password);
            Debug.WriteLine($"{model.userName}|{model.password}");
            if (result&& ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { userName = model.userName });
                SessionHelper.SetSession(new UserSession() { passWord = model.password });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", $"Login fail, double check your username or password");
            }
            return View();
        }
    }
}