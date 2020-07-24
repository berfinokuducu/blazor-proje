using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLeaflet.Samples.Models
{
    public class Rezervation
    {
        public int ID { get; set; }
        public int CID { get; set; }
        public int RID { get; set; }
        public string check_in { get; set; }
        public string check_out { get; set; }
    }
}
