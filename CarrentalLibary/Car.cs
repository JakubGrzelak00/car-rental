using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace CarrentalLibary
{
    public class Car
    {
        public string name { get; set; }
        public string type { get; set; }
        public string brand { get; set; }
        public string fuelType { get; set; }
        public int price { get; set; }

        public List<Car> GenerateCarList()
        {
            List<Car> cars = new List<Car>();

            string path = $"{Directory.GetCurrentDirectory()}\\CarsList.json";
            Console.WriteLine(Directory.GetCurrentDirectory());
            string jsonText = File.ReadAllText(path);

            cars = JsonConvert.DeserializeObject<List<Car>>(jsonText);

            return cars;
        }

        public List<Car> FilterCars(string carType, string carFuelType, string carBrand)
        {
            List<Car> cars = GenerateCarList();
            List<Car> carsFilteredByCarType = new List<Car>();
            List<Car> carsFilteredByCarTypeAndFuelType = new List<Car>();
            List<Car> carsFilteredByAllCategories = new List<Car>();

            if (carType != "Any Type")
            {
                foreach (Car car in cars)
                {
                    if (car.type == carType)
                    {
                        carsFilteredByCarType.Add(car);
                    }
                }
            }
            else
            {
                carsFilteredByCarType = cars;
            }
            if (carFuelType != "Any Fuel Type")
            {
                foreach (Car car in carsFilteredByCarType)
                {
                    if (car.fuelType == carFuelType)
                    {
                        carsFilteredByCarTypeAndFuelType.Add(car);
                    }
                }
            }
            else
            {
                carsFilteredByCarTypeAndFuelType = carsFilteredByCarType;
            }
            if (carBrand != "Any Brand")
            {
                foreach (Car car in carsFilteredByCarTypeAndFuelType)
                {
                    if (car.brand == carBrand)
                    {
                        carsFilteredByAllCategories.Add(car);
                    }
                }
            }
            else
            {
                carsFilteredByAllCategories = carsFilteredByCarTypeAndFuelType;
            }

            return carsFilteredByAllCategories;
        }
    }
}
