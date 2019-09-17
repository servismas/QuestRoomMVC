namespace QuestRoomMVC.DAL
{
    using QuestRoomMVC.DAL.Entities;
    using QuestRoomMVC.DAL.Initializer;
    using System;
    using System.Data.Entity;
    using System.Diagnostics;
    using System.Linq;

    public class QuestContext : DbContext
    {
        public QuestContext()
            : base("name=QuestContext")
        {
            Database.SetInitializer(new RoomsInitializer());
            Database.Log = (s =>
            {
                Debug.Write(s);
            });
        }

        public DbSet<QuestRoom> Rooms { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}