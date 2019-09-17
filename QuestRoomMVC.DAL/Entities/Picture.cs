using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.DAL.Entities
{
    public class Picture
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public virtual QuestRoom QuestRoom { get; set; }
    }
}
