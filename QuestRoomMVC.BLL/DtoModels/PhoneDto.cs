using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.BLL.DtoModels
{
    public class PhoneDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public QuestRoomDto QuestRoom { get; set; }
    }
}
