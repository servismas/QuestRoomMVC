using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using QuestRoomMVC.BLL.Abstraction;
using QuestRoomMVC.BLL.Mapping;
using QuestRoomMVC.BLL.Services.Implementation;
using QuestRoomMVC.DAL;
using QuestRoomMVC.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomMVC.UI.App_Start
{
    public class AutofacContainer
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            RegisterDependencies(builder);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }

        private static void RegisterDependencies(ContainerBuilder builder)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperProfile());
            });
            IMapper mapper = new Mapper(mapperConfig);
            builder.RegisterInstance(mapper).As<IMapper>();

            builder.RegisterType<QuestContext>().As<DbContext>().SingleInstance();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(DAL.Repository.IRepository<>));
            builder.RegisterType<RoomService>().As<IRoomService>();
        }
    }
}