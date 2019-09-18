using QuestRoomMVC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.DAL.Initializer
{
    //public class RoomsInitializer : DropCreateDatabaseIfModelChanges<QuestContext>
    public class RoomsInitializer : DropCreateDatabaseAlways<QuestContext>
    {
        protected override void Seed(QuestContext context)
        {
            Phone phone1 = new Phone()
            {
                Number = "08003005001"
            };
            Phone phone2 = new Phone()
            {
                Number = "08003005002"
            };
            Phone phone3 = new Phone()
            {
                Number = "08003005002"
            };
            Phone phone4 = new Phone()
            {
                Number = "08003005002"
            };
            Phone phone5 = new Phone()
            {
                Number = "08003005002"
            };
            Phone phone6 = new Phone()
            {
                Number = "08003005002"
            };

            Picture picture1 = new Picture()
            {
                Path = "https://s.barraques.cat/pngfile/s/140-1406931_photo-wallpaper-house-clown-mask-halloween-halloween-killer.jpg"
            };
            Picture picture2 = new Picture()
            {
                Path = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQw5vi4swgWLFT2Ghb5R_SZcsQhf-yeQILA61ke_lNGRL7BsAq7"
            };
            Picture picture3 = new Picture()
            {
                Path = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmtZlig0_thn8YwAd9zkj4zsUZQAL-p51ubQo8NwqgHxyT7WFT"
            };
            Picture picture4 = new Picture()
            {
                Path = "https://data.whicdn.com/images/246449584/large.jpg"
            };
            Picture picture5 = new Picture()
            {
                Path = "https://s3.reutersmedia.net/resources/r/?d=20190531&i=RCV006SUK&w=&r=RCV006SUK&t=2"
            };
            Picture picture6 = new Picture()
            {
                Path = "https://www.nationalgeographic.com/content/dam/science/2019/02/08/hidden-world/image-42-mealworm_jwn.adapt.1900.1.jpg"
            };

            QuestRoom room = new QuestRoom()
            {
                Name = "TestRoom",
                Address = "TestAddress",
                CompanyName = "TestCompany",
                Description = "TestDescription",
                Email = "test@email.com",
                FearLevel = 3,
                GameTime = 30,
                HardLevel = 3,
                MaxPlayersCount = 3,
                MinPlayersAge = 20,
                MinPlayersCount = 5,
                Rate = 0,
                Logo = "https://www.telegraph.co.uk/content/dam/films/2016/10/31/juon3_trans_NvBQzQNjv4BqNJjoeBT78QIaYdkJdEY4CnGTJFJS74MYhNY6w3GNbO8.jpg?imwidth=450"
            };
            room.PhoneNumbers.Add(phone1);
            room.PhoneNumbers.Add(phone2);

            room.Pictures.Add(picture1);
            room.Pictures.Add(picture2);

            QuestRoom room1 = new QuestRoom()
            {
                Name = "TestRoom1",
                Address = "TestAddress1",
                CompanyName = "TestCompany1",
                Description = "TestDescription1",
                Email = "test1@email.com",
                FearLevel = 3,
                GameTime = 30,
                HardLevel = 3,
                MaxPlayersCount = 3,
                MinPlayersAge = 20,
                MinPlayersCount = 5,
                Rate = 0,
                Logo = "https://d13ezvd6yrslxm.cloudfront.net/wp/wp-content/images/IMG_3923-1-700x420.jpg"
            };
            room1.PhoneNumbers.Add(phone3);
            room1.PhoneNumbers.Add(phone4);

            room1.Pictures.Add(picture3);
            room1.Pictures.Add(picture4);

            QuestRoom room2 = new QuestRoom()
            {
                Name = "TestRoom2",
                Address = "TestAddress2",
                CompanyName = "TestCompany2",
                Description = "TestDescription2",
                Email = "test2@email.com",
                FearLevel = 3,
                GameTime = 30,
                HardLevel = 3,
                MaxPlayersCount = 3,
                MinPlayersAge = 20,
                MinPlayersCount = 5,
                Rate = 0,
                Logo= "https://drifterplanet.com/wp-content/uploads/2017/12/Cancun-Private-Beach-Party.jpg"
            };
            room2.PhoneNumbers.Add(phone5);
            room2.PhoneNumbers.Add(phone6);

            room2.Pictures.Add(picture5);
            room2.Pictures.Add(picture6);
                    
            context.Rooms.Add(room);
            context.Rooms.Add(room1);
            context.Rooms.Add(room2);
            context.SaveChanges();
        }
    }
}
