using System;

namespace CarsProject 
{// 01232023 First version
    internal class Program
    {
        static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            // main menu
            // prompt for user input, show menu until 4
            string input = "";

            while (input != "4")
            {
                Console.WriteLine(" Welcome to Jeremy's Car Dealership, where your credit goes to die!");
                Console.WriteLine(" 1. Add a new car");
                Console.WriteLine(" 2. Sell a current car");
                Console.WriteLine(" 3. List all cars");
                Console.WriteLine(" 4. Quit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddCar();
                        break;
                    case "2":
                        DeleteCar();
                        break;
                    case "3":
                        ListCars();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void AddCar()
        {
            Console.WriteLine("Enter the year of the vehicle:");
            Car car = new Car();
            int year = int.Parse(Console.ReadLine());
            car.year = year;
            Console.WriteLine("Enter the make of the vehicle:");
            string make = Console.ReadLine();
            car.make = make;
            Console.WriteLine("Enter the model of the vehicle:");
            string model = Console.ReadLine();
            car.model = model;
            Console.WriteLine("Enter the number of doors on the vehicle:");
            int numOfDoors = int.Parse(Console.ReadLine());
            car.numberOfDoors = numOfDoors;
            Console.WriteLine("Enter the price of the vehicle:");
            double price = double.Parse(Console.ReadLine());
            car.price = price;
            cars.Add(car);
            Console.WriteLine("Your car is a:" + car.year.ToString() + " " + car.make + " " + car.model);
        }
        public static void DeleteCar()
        {
            //ask user which car to delete, and delete that car from the list. 
            Console.WriteLine("Enter the number of the vehicle you would like to remove:");

            int carToRemove = int.Parse(Console.ReadLine());
            cars.RemoveAt(carToRemove);
            Console.WriteLine("");



        }
        public static void ListCars()
        {
            int i = 1;
            foreach (Car car in cars)
            {
                Console.WriteLine("Car #" + i + " " + car.year.ToString() + " " + car.make + "  " + car.model + " " + car.price.ToString());
                i++; //i= i+i, --> i++
            }
        }
    }
}