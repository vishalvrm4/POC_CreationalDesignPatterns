using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public enum CarCountry { US, India }

    public class CarClient
    {
        private readonly ICar car;
        private readonly ICarSpecification carSpecification;

        public CarClient(CarCountry country)
        {
            if (country == CarCountry.US)
            {
                car = new Sedan();
                carSpecification = new USCarSpecification();
            }
            else if (country == CarCountry.India)
            {
                car = new Hatchback();
                carSpecification = new IndiaCarSpecification();
            }
        }

        public void CarDetails()
        {
            car.Assemble();
            carSpecification.Display();
        }
    }

    public interface ICarFactory
    {
        ICar createCar();
        ICarSpecification createCarSpecification();
    }

    public class USCarFactory : ICarFactory
    {
        public ICar createCar()
        {
            return new Sedan();
        }

        public ICarSpecification createCarSpecification()
        {
            return new USCarSpecification();
        }
    }

    public class IndiaCarFactory : ICarFactory
    {
        public ICar createCar()
        {
            return new Hatchback();
        }

        public ICarSpecification createCarSpecification()
        {
            return new IndiaCarSpecification();
        }
    }

    public interface ICar
    {
        void Assemble();
    }

    public interface ICarSpecification 
    {
        void Display();
    }

    public class Sedan : ICar
    {
        public void Assemble() => Console.WriteLine("Assemble Sedan Car");
    }

    public class Hatchback : ICar
    {
        public void Assemble() => Console.WriteLine("Assemble Hatchback Car");
    }

    public class USCarSpecification : ICarSpecification
    {
        public void Display() => Console.WriteLine("US Car Specification");
    }

    public class IndiaCarSpecification : ICarSpecification
    {
        public void Display() => Console.WriteLine("India Car Specification");
    }
}
