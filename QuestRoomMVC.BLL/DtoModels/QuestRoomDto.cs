﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomMVC.BLL.DtoModels
{
    public class QuestRoomDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GameTime { get; set; }
        public int MinPlayersCount { get; set; }
        public int MaxPlayersCount { get; set; }
        public int MinPlayersAge { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public int Rate { get; set; }
        [Range(1, 5)]
        public int FearLevel { get; set; }
        [Range(1, 5)]
        public int HardLevel { get; set; }
        public string Logo { get; set; }
        public ICollection<PictureDto> Pictures { get; set; }
        public ICollection<PhoneDto> PhoneNumbers { get; set; }
        public QuestRoomDto()
        {
            Pictures = new List<PictureDto>();
            PhoneNumbers = new List<PhoneDto>();
        }
    }
}
