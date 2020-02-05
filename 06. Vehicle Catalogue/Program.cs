using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    public class Car
    {
        public string Type = "Car";
        public string Model { get; set; }
        public string Color { get; set; }
        public string HorsePower { get; set; }

        public Car(string model, string color, string horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
    }

    public class Truck
    {
        public string Type = "Truck";
        public string Model { get; set; }
        public string Color { get; set; }
        public string HorsePower { get; set; }

        public Truck(string model, string color, string horsePower)
        {

            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

    }
    class Program
    {
        static void Print(string type, string model, string color, string horsepower)
        {
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Horsepower: {horsepower}");
        }

        static void Main()
        {
            List<Car> carCatalog = new List<Car>();
            List<Truck> truckCatalog = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] inputInfo = input.Split();
                string typeOfVehicle = inputInfo[0];

                if (typeOfVehicle == "car")
                {
                    Car newCar = new Car(inputInfo[1], inputInfo[2], inputInfo[3]);
                    carCatalog.Add(newCar);
                }
                else if (typeOfVehicle == "truck")
                {
                    Truck newTruck = new Truck(inputInfo[1], inputInfo[2], inputInfo[3]);
                    truckCatalog.Add(newTruck);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }

                string modelOfVehicle = input;
                string type = "";
                string model = "";
                string color = "";
                string horsepower = "";

                if (carCatalog.Any(x => x.Model == modelOfVehicle))
                {
                    for (int i = 0; i < carCatalog.Count; i++)
                    {
                        Car curr = carCatalog[i];

                        if (curr.Model == modelOfVehicle)
                        {
                            type = curr.Type;
                            model = curr.Model;
                            color = curr.Color;
                            horsepower = curr.HorsePower;
                        }
                    }

                    Print(type, model, color, horsepower);
                }

                else if (truckCatalog.Any(x => x.Model == modelOfVehicle))
                {
                    for (int i = 0; i < truckCatalog.Count; i++)
                    {
                        Truck curr = truckCatalog[i];

                        if (curr.Model == modelOfVehicle)
                        {
                            type = curr.Type;
                            model = curr.Model;
                            color = curr.Color;
                            horsepower = curr.HorsePower;

                        }
                    }

                    Print(type, model, color, horsepower);
                }

            }

            double averangeCarHorsepower = 0;
            double averangeTruckHorsepower = 0;

            for (int i = 0; i < carCatalog.Count; i++)
            {
                int currHp = int.Parse(carCatalog[i].HorsePower);
                averangeCarHorsepower += currHp;
            }

            for (int i = 0; i < truckCatalog.Count; i++)
            {
                int currHp = int.Parse(truckCatalog[i].HorsePower);
                averangeTruckHorsepower += currHp;
            }

            if (carCatalog.Count > 0)
            {
                averangeCarHorsepower /= carCatalog.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averangeCarHorsepower:F2}.");
            if (truckCatalog.Count > 0)
            {
                averangeTruckHorsepower /= truckCatalog.Count;
               
            }
            Console.WriteLine($"Trucks have average horsepower of: {averangeTruckHorsepower:F2}.");
        }
    }
}
