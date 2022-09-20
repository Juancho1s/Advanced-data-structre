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
        private bool suspicionOfFraud = false;
        private string[] favoriteBrand;
        private string [] favoriteColor;

        private List<License> licenses;
        private List<Vehicle> vehicles;

        public Person(string keyCode, string name, string surName, int age, string gender, string[] favoriteBrand, string[] favoriteColor)
        {
            this.name = name;
            this.surNames = surName;
            this.gender = gender;
            this.age = age;
            this.favoriteBrand = favoriteBrand;
            this.favoriteColor = favoriteColor;
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
                if (newVehicle.getColor().Equals(favoriteColor))
                {
                    vehicles.Add(newVehicle);                 
                }
                if (vehicles.Count > 5)
                {
                    suspicionOfFraud = true;
                }
                return;                
            }
            if (gender.Equals("Man"))
            {
                if (newVehicle.getBrand().Equals(favoriteBrand))
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
                        if (vehicles[j].getModel().Equals(vehicleModel) & vehicles[j].getBrand().Equals(vehicleBrand))
                        {
                            vehicles.Remove(vehicles[j]);
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
