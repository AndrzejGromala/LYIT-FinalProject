using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCollectionWithDB.Models
{
    public class CarModel  // Car model class variables setters and getters
    {
        public int CarId { get; set; }
        public string CarMkModel { get; set; }
        public string Engine { get; set; }
        public string BodyType { get; set; }
        public string Transmission { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Value { get; set; }
    }
}
