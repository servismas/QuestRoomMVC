using AutoMapper;
using QuestRoomMVC.BLL.Abstraction;
using QuestRoomMVC.BLL.Mapping;
using QuestRoomMVC.BLL.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomMVC.UI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService roomService;
        //public RoomController()
        //{
        //    var mapperConfig = new MapperConfiguration(cfg =>
        //    {
        //        cfg.AddProfile(new MapperProfile());
        //    });

        //    IMapper mapper = new Mapper(mapperConfig);
        //    roomService = new RoomService(mapper);
        //}
        public RoomController(IRoomService _roomService)
        {
            roomService = _roomService;
        }
        // GET: Room
        public async Task<ActionResult> Index()
        {
            var rooms = await roomService.GetRooms();
            return View(rooms);
        }
    }
}