using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Vehicle
    {
        
        private string type;
        private DateTime year;
        private string description;
        private string wheels;
        private string color;
        private string brand;
        private string model;

        public Vehicle(string year, string wheels, string color, string brand, string type, string description, string model)
        {
            this.year = DateTime.Parse(year);
            this.wheels = wheels;
            this.color = color;
            this.brand = brand;
            this.type = type;
            this.description = description;
            this.model = model;
        }

        public string getColor()
        {
            return color;
        }

        public string getBrand()
        {
            return brand;
        }

        public string getModel()
        {
            return model;
        }
    }
}
