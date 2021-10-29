﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public DateTime DateAdded { get; set; }
        public int WorshipId { get; set; }

        public virtual Worship Worship { get; set; }
    }
}
