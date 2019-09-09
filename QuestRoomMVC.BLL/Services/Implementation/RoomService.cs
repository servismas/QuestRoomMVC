using AutoMapper;
using QuestRoomMVC.BLL.Abstraction;
using QuestRoomMVC.BLL.DtoModels;
using QuestRoomMVC.DAL.Entities;
using QuestRoomMVC.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.BLL.Services.Implementation
{
    public class RoomService : IRoomService
    {
        private readonly IMapper mapper;
        private readonly IRepository<QuestRoom> tempRepo;
        public RoomService(IMapper _mapper)
        {
            tempRepo = new Repository<QuestRoom>();
            mapper = _mapper;
        }
        public List<QuestRoomDto> GetAllTemp()
        {
            var rooms = tempRepo.GetAllTemp();
            return mapper.Map<IEnumerable<QuestRoom>, ICollection<QuestRoomDto>>(rooms).ToList();

        }
        public Task<ICollection<QuestRoomDto>> GetRooms()
        {
            throw new NotImplementedException();
        }
    }
}
