using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Task
{
    public class Adress
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public string House
        {
            get
            {
                return house;
            }

            set
            {
                house = value;
            }
        }

        public string Appartment
        {
            get
            {
                return apartment;
            }

            set
            {
                apartment = value;
            }
        }

        public override string ToString()
        {
            return "Index:" + index + " Country:" + country+ " City:" + city + " Sreet:" + street+ " House:" + house +" Appartment:" + apartment;
     
        }
    }
}
