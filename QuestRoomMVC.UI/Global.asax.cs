using AutoMapper;
using QuestRoomMVC.BLL.Mapping;
using QuestRoomMVC.UI.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuestRoomMVC.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutofacContainer.Configure();
            //var mapperConfig = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile(new MapperProfile());
            //});

            //IMapper mapper = new Mapper(mapperConfig);
        }
    }
}
