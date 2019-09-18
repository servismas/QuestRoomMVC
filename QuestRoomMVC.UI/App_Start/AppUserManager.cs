using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using QuestRoomMVC.DAL;
using QuestRoomMVC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRoomMVC.UI.App_Start
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(IUserStore<AppUser> store) : base(store)
        {
        }
        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            var db = context.Get<QuestContext>();

            var manager = new AppUserManager(new UserStore<AppUser>(db));
            // Settings for UserMaanager

            // Настройка логики проверки имен пользователей
            manager.UserValidator = new UserValidator<AppUser>(manager)
            {
                //в имени юзер могут быть буквы символы и цифры
                AllowOnlyAlphanumericUserNames = false,
                //емейл должен быть уникальным
                RequireUniqueEmail = true
            };

            //BestPassword Qwe123!!
            manager.PasswordValidator = new PasswordValidator
            {
                RequireDigit = true,
                RequiredLength = 6,
                RequireLowercase = true,
                RequireUppercase = true,
                RequireNonLetterOrDigit = true
            };

            // Настройка параметров блокировки по умолчанию
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            //Настройка токена
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider =
                    new DataProtectorTokenProvider<AppUser>(dataProtectionProvider.Create("SuperToken"));
            }


            if (manager.FindByEmail("admin@gmail.com") == null)
            {
                var user = new AppUser { Email = "admin@gmail.com", UserName = "admin@gmail.com" };
                var res = manager.Create(user, "Qwe123!!");

                RoleManager<IdentityRole> rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

                rm.Create(new IdentityRole { Name = "ADMIN" });

                var admin = manager.FindByEmail("admin@gmail.com");
                manager.AddToRole(admin.Id, "ADMIN");
            }
            return manager;
        }
    }
}