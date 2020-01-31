using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneApplication.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }
        public string URL { get; set; }
        public DateTime Founded { get; set; }
        public List<Phone> PhoneList { get; set; }

        public Manufacturer(int manufacturerID, string manufacturerName, string uRL, DateTime founded, List<Phone> phoneList)
        {
            ManufacturerID = manufacturerID;
            ManufacturerName = manufacturerName;
            URL = uRL;
            Founded = founded;
            PhoneList = phoneList;
        }

        public Manufacturer(string manufacturerName, string uRL, DateTime founded, List<Phone> phoneList)
        {
            ManufacturerName = manufacturerName;
            URL = uRL;
            Founded = founded;
            PhoneList = phoneList;
        }

        public Manufacturer() { }
    }
}