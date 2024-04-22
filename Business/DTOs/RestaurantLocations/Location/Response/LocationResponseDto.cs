﻿using Business.DTOs.RestaurantLocations.OpeningHours.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.RestaurantLocations.Location.Response
{
    public class LocationResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }



        public OpeningHoursResponseDto OpeningHours { get; set; }
    }
}