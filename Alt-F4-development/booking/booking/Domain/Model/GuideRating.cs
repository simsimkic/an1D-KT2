﻿using booking.Model;
using booking.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Domain.Model
{
    public class GuideRating : ISerializable
    {
        public int Id { get; set; }
        public int TourKnowledge { get; set; }
        public int LanguageKnowledge { get; set; }
        public int TourEnjoyment { get; set; }
        public string Comment { get; set; }
        public int AppointmentId { get; set; }  

        public GuideRating() { }
        public GuideRating(int id, int tourKnowledge, int languageKnowledge, int tourEnjoyment, int appointmentId, string comment)
        {
            Id = id;
            TourKnowledge = tourKnowledge;
            LanguageKnowledge = languageKnowledge;
            TourEnjoyment = tourEnjoyment;
            AppointmentId = appointmentId;
            Comment = comment;
        }

        public void FromCSV(string[] values)
        {
            Id = int.Parse(values[0]);
            TourKnowledge = int.Parse(values[1]);
            LanguageKnowledge = int.Parse(values[2]);
            TourEnjoyment = int.Parse(values[3]);
            AppointmentId = int.Parse(values[4]);
            Comment = values[5];
        }

        public string[] ToCSV()
        {
            string[] cssValues =
            {
                Id.ToString(),
                TourKnowledge.ToString(),
                LanguageKnowledge.ToString(),
                TourEnjoyment.ToString(),
                AppointmentId.ToString(),
                Comment.ToString()
            };
            return cssValues;
        }
    }
}
