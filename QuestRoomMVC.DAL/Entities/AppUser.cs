using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.DAL.Entities
{
    public class AppUser : IdentityUser
    {
        public string City { get; set; }

    }
}
