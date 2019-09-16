using QuestRoomMVC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //private List<QuestRoom> questRooms;
        protected DbContext context;
        public Repository(DbContext _context)
        {
            context = _context;
            //questRooms = new List<QuestRoom>();
            //QuestRoom room = new QuestRoom() { Name = "TestRoom", Address = "TestAddress", CompanyName = "TestCompany", Description = "TestDescription", Email = "test@email.com", FearLevel = 3, GameTime = DateTime.Parse("2011-03-21 13:26"), HardLevel = 3, MaxPlayersCount = 3, MinPlayersAge = 20, MinPlayersCount = 5, Rate = 0 };
            //questRooms.Add(room);
            //questRooms.Add(room);
            //questRooms.Add(room);
        }
        //public List<QuestRoom> GetAllTemp()
        //{
        //    return questRooms;
        //}

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
