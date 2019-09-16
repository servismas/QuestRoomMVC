using QuestRoomMVC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.DAL.Initializer
{
    public class RoomsInitializer : DropCreateDatabaseIfModelChanges<QuestContext>
    {
        protected override void Seed(QuestContext context)
        {
            QuestRoom room = new QuestRoom() { Name = "TestRoom", Address = "TestAddress", CompanyName = "TestCompany", Description = "TestDescription", Email = "test@email.com", FearLevel = 3, GameTime = DateTime.Parse("2011-03-21 13:26"), HardLevel = 3, MaxPlayersCount = 3, MinPlayersAge = 20, MinPlayersCount = 5, Rate = 0 };

            context.Rooms.Add(room);
            context.SaveChanges();
            context.Rooms.Add(room);
            context.SaveChanges();
            context.Rooms.Add(room);
            context.SaveChanges();
        }
    }
}
