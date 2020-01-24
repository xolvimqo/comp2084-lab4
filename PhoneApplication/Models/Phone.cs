using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public int PhoneID;
        public string PhoneName;
        public string Manufacturer;
        public string MSRP;
        public string ScreenSize;
        public DateTime DateRealeased;

        public Phone(int phoneID, string phoneName, string manufacturer, string mSRP, string screenSize, DateTime dateRealeased)
        {
            PhoneID = phoneID;
            PhoneName = phoneName;
            Manufacturer = manufacturer;
            MSRP = mSRP;
            ScreenSize = screenSize;
            DateRealeased = dateRealeased;
        }
    }
}