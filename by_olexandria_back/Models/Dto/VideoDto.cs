﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Dto
{
    public class VideoDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string VideoPath { get; set; }
        public DateTime DateAdded { get; set; }
        public int WorshipId { get; set; }
    }
}
