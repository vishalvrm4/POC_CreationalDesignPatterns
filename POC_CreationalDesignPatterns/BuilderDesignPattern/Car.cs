using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Car
    {
        public string Engine {  get; set; }
        public string Wheel {  get; set; }
        public string Body {  get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Engine : {Engine}");
            Console.WriteLine($"Wheel : {Wheel}");
            Console.WriteLine($"Body : {Body}");
        }
    }

    public interface ICarBuilder
    {
        void BuildEngine();
        void BuildWheel();
        void BuildBody();
        Car GetCar();
    }

    public class SedanCarBuilder : ICarBuilder
    {
        private Car car = new Car();
        public void BuildBody()
        {
            car.Body= "Sedan Body";
        }

        public void BuildEngine()
        {
            car.Engine= "Sedan Engine";
        }

        public void BuildWheel()
        {
            car.Wheel= "Sedan Wheel";
        }

        public Car GetCar()
        {
            return car;
        }
    }

    public class SUVCarBuilder : ICarBuilder
    {
        private Car car = new Car();
        public void BuildBody()
        {
            car.Body= "SUV Body";
        }

        public void BuildEngine()
        {
            car.Engine= "SUV Engine";
        }

        public void BuildWheel()
        {
            car.Wheel= "SUV Wheel";
        }

        public Car GetCar()
        {
            return car;
        }
    }

    public class CarDirector
    {
        private ICarBuilder carBuilder;

        public CarDirector(ICarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public void ConstructCar()
        {
            carBuilder.BuildWheel();
            carBuilder.BuildEngine();
            carBuilder.BuildBody();
        }

        public Car GetCar()
        {
            return carBuilder.GetCar();
        }
    }
}
