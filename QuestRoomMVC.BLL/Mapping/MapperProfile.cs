using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using QuestRoomMVC.BLL.DtoModels;
using QuestRoomMVC.DAL.Entities;

namespace QuestRoomMVC.BLL.Mapping
{
    public class MapperProfile :Profile
    {
        public MapperProfile()
        {
            CreateMap<QuestRoom, QuestRoomDto>();
        }
    }
}
