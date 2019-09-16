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
        //private readonly IRepository<QuestRoom> tempRepo;
        private readonly IRepository<QuestRoom> repository;
        public RoomService(IMapper _mapper, IRepository<QuestRoom> _repository)
        {
            //tempRepo = new Repository<QuestRoom>();
            repository = _repository;
            mapper = _mapper;
        }
        //public List<QuestRoomDto> GetAllTemp()
        //{
        //    //var rooms = tempRepo.GetAllTemp();
        //    var rooms = repository.GetAllTemp();
        //    return mapper.Map<IEnumerable<QuestRoom>, ICollection<QuestRoomDto>>(rooms).ToList();

        //}
        public async Task<ICollection<QuestRoomDto>> GetRooms()
        {
            var rooms = await repository.GetAll();
            return mapper.Map<IEnumerable<QuestRoom>, ICollection<QuestRoomDto>>(rooms);
        }
    }
}
