using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using QuestRoomMVC.DAL;
using QuestRoomMVC.UI.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//[assembly: OwinStartup(typeof(GameStoreMVC.UI.Startup))]

namespace QuestRoomMVC.UI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(QuestContext.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                //Если нет прав то редирект по ссылке
                LoginPath = new PathString("/Account/Login"),
                CookieName = "SuperPuperToken"
            });
        }
    }
}