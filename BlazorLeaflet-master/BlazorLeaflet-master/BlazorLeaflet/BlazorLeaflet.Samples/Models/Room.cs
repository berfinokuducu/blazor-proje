using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLeaflet.Samples.Models
{
    public class Room
    {
        public int ID { get; set; }
        public int HID { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public int floor { get; set; }
        public string image { get; set; }
        public string bolcony_information { get; set; }
    }
}
