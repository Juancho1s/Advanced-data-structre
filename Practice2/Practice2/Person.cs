using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Person
    {

        private string name;
        private string surNames;
        private int age;
        private string gender;
        private string keyCode;
        private bool suspicionOfFraud;
        private string theWorstBrand;
        private string theWorstColor;

        private List<License> licenses;
        private List<Vehicle> vehicles;

        public Person(string keyCode, string name, string surName, int age, string gender, string theWorstBrand, string theWorstColor)
        {
            this.name = name;
            this.surNames = surName;
            this.gender = gender;
            this.age = age;
            this.theWorstBrand = theWorstBrand;
            this.theWorstColor = theWorstColor;
            this.keyCode = keyCode;
            this.vehicles = new List<Vehicle>();
            this.licenses = new List<License>();
        }

        public void addLicense(License newLicense)
        {
            if (age < 90)
            {
                for (int i = 0; i < licenses.Count; i++)
                {
                    if (licenses[i].getType().Equals(newLicense.getType()))
                    {
                        if (licenses[i].getStatus() == false)
                        {
                            licenses.Remove(licenses[i]);
                            licenses.Add(newLicense);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("You already have this type of license (Active) in the list");
                            return;
                        }
                    }
                }
                licenses.Add(newLicense);
            }
            else
            {
                Console.WriteLine("Sorry but  you are very old.");
            }
        }

        public void addVehicle(Vehicle newVehicle)
        {
            if (gender.Equals("Woman"))
            {
                if (newVehicle.getColor().Equals(theWorstColor))
                {
                    return;
                }
                vehicles.Add(newVehicle);
                if (vehicles.Count > 5)
                {
                    suspicionOfFraud = true;
                }
            }
            if (gender.Equals("Man"))
            {
                if (newVehicle.getBrand().Equals(theWorstBrand))
                {
                    Console.WriteLine("This car is the worst for this client.");
                    return;
                }
                vehicles.Add(newVehicle);
                if (vehicles.Count > 5)
                {
                    suspicionOfFraud = true;
                }
            }
        }

        public void cancelVehicle(string vehicleType, string vehicleBrand, string vehicleModel)
        {
            for (int i = 0; i < licenses.Count; i++)
            {
                if (vehicleType.Equals(licenses[i].getType()))
                {
                    for (int j = 0; j < vehicles.Count; j++)
                    {
                        if (vehicles[i].Equals(vehicleModel) & vehicles[i].Equals(vehicleBrand))
                        {
                            vehicles.RemoveAt(i);
                            return;
                        }
                    }
                    Console.WriteLine("The vehicle was not found");
                    return;
                }
            }
            Console.WriteLine("The vehicle was not found");
        }
    
        public string getKeyCode()
        {
            return keyCode;
        }
    }
}
