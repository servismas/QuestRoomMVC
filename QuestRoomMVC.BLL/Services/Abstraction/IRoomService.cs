using QuestRoomMVC.BLL.DtoModels;
using QuestRoomMVC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.BLL.Abstraction
{
    public interface IRoomService
    {
        Task<ICollection<QuestRoomDto>> GetRooms();
        //List<QuestRoomDto> GetAllTemp();
    }
}
