using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using QuestRoomMVC.DAL.Entities;
using QuestRoomMVC.UI.App_Start;
using QuestRoomMVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomMVC.UI.Controllers
{
    public class AccountController : Controller
    {
        private AppUserManager _userManager;

        public AppUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
            private set { _userManager = value; }
        }

        private IAuthenticationManager _authManager;

        public IAuthenticationManager AuthManager
        {
            get
            {
                return _authManager ?? HttpContext.GetOwinContext().Authentication;
            }
            private set { _authManager = value; }
        }


        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(UserRegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser
            {
                Email = model.Email,
                UserName = model.Email,
                City = model.City
            };

            var result = await UserManager.CreateAsync(appUser, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Room");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }

            return View();
        }

        [HttpGet]
        public ActionResult Login(string ReturnUri)
        {
            ViewBag.ReturnUri = ReturnUri;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserLoginModel model, string ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await UserManager.FindAsync(model.Email, model.Password);

            if (user==null)
            {
                ModelState.AddModelError("", "User not exists");
                return View();
            }
            await SignInAsync(user, model.IsPersistance);

            if (String.IsNullOrEmpty(ReturnUrl))
                return RedirectToAction("Index", "Room");
            return Redirect(ReturnUrl);
        }

        private async Task SignInAsync(AppUser user, bool isPersistent)
        {
            AuthManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            AuthManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
        }
        public ActionResult SignOut()
        {
            AuthManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Room");
        }
    }
}