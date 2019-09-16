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
        // Your context has been configured to use a 'QuestContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QuestRoomMVC.DAL.QuestContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QuestContext' 
        // connection string in the application configuration file.
        public QuestContext()
            : base("name=QuestContext")
        {
            Database.SetInitializer(new RoomsInitializer());
            Database.Log = (s =>
            {
                Debug.Write(s);
            });
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<QuestRoom> Rooms { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}