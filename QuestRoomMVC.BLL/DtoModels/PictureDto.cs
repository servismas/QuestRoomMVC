using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.BLL.DtoModels
{
    public class PictureDto
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public QuestRoomDto QuestRoom { get; set; }
    }
}
