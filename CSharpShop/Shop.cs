using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class shop
    {
        // FEATURES
        private string shopName;
        private string address;        
        private int houseNumber;
        private string citty;

        // CONSTRUCTORS

        public shop(string shopName, string address, int houseNumber, string citty)
        {
            this.shopName = shopName;
            this.address = address;        
            this.houseNumber = houseNumber;
            this.citty = citty;
        }

        // GETTERS

        public string GetShopName { get { return shopName; } }
        public string GetAddress { get { return address; } }
        public int GetHouseNumber { get { return houseNumber; } }
        public string GetCitty { get { return citty; } }

        // SETTERS

        public void SetShopName(string shopName) { this.shopName = shopName; }
        public void SetAddress(string address) { this.address = address;}
        public void SetHouseNumber(int houseNUmber) { this.houseNumber = houseNUmber;}
        public void SetCitty(string citty) { this.citty = citty;}

        
    }
}
