using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLeaflet.Samples.Data
{
    public class Hotels
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string city { get; set; }//address
        public string district { get; set; }//address
        public string street { get; set; }//address
        public int No { get; set; } //address
        public string activity_area { get; set; }
        public string image { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
