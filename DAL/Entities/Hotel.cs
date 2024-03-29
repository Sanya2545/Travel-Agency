﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Hotel
    {
        public Hotel() { }
        public Hotel(string Name, int Stars, string Address)
        {
            this.Name = Name;
            this.Stars = Stars;
            this.Address = Address;
            Rooms = new List<HotelRoom>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public virtual List<HotelRoom> Rooms { get; set; }
        public string Address { get; set; }
    }
}
