using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tranning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1=new Car("BMW","Mustang","Black",2025);
            Car car2 = new Car("BMW", "Mustang", "white", 2025);
            Car car3 = new Car("BMW", "Mustang", "white", 2025);
            Console.WriteLine(Car.numberOfCars);
            car1.Drive();

            Console.ReadKey();
        }
        
    }
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int year;
        static public int numberOfCars;

        public Car(string make,string model, string color,int year) {
            this.make = make;   
            this.model = model;
            this.color = color;
            this.year = year;
            numberOfCars++;
        }
        public void Drive()
        {
            Console.WriteLine($"You Drive {make} {model} {color} {year} ");
        }
    }
}
