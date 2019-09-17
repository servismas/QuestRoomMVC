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
        protected DbContext context;
        public Repository(DbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
