using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLeaflet.Samples.Models
{
    public class Scoring
    {
        public int ID { get; set; }
        public int CID { get; set; }
        public int HID { get; set; }
        public int score { get; set; }
        public string comment { get; set; }
    }
}
