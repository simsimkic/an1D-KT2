
﻿using booking.DTO;
using booking.Model;
using booking.Serializer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

﻿using booking.Model;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking.Repository
{
    public class AccommodationRepository
    {
        private List<Accommodation> accommodations;
        private Serializer<Accommodation> serializer;

        private readonly string fileName = "../../../Resources/Data/accommodation.csv";
        public AccommodationRepository() 

        {
            //accommodations = new List<Accommodation>();
            serializer = new Serializer<Accommodation>();
            accommodations = serializer.FromCSV(fileName);
        }
        public List<Accommodation> GetAll()
        {
            return accommodations;
        }

        public Accommodation GetById(int id)
        {
            return accommodations.Where(a => a.Id == id).ToList()[0];
        }

        public void AddAccommodation(Accommodation acc)
        {

            accommodations.Add(acc);
            serializer.ToCSV(fileName, accommodations);

        }
        public Accommodation FindById(int id)
        {
            return accommodations.Find(a => a.Id == id);
        }

    }
}
