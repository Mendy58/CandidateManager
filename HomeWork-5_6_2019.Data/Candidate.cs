using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_5_6_2019.Data
{
    public class Candidate
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool? Confirmed { get; set; }
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
    }
}
