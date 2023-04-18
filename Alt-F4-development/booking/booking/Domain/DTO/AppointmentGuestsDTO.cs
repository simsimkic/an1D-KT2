﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking.Model;

namespace booking.Domain.DTO
{
    public class AppointmentGuestsDTO
    {
        

        public string Name { get; set; }
        public Location Location { get; set; }
        public string Language { get; set; }
        public DateAndTime StartTime { get; set; }
        public int NumberOfGuests { get; set; }

        public AppointmentGuestsDTO(string name, Location location, string language, DateAndTime startTime, int numberOfGuests)
        {
            Name = name;
            Location = location;
            Language = language;
            StartTime = startTime;
            NumberOfGuests = numberOfGuests;
        }

        public AppointmentGuestsDTO()
        {
        }

    }
}
