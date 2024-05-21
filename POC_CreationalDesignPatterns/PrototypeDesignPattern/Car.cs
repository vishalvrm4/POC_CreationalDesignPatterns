using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public interface IPrototype<T>
    {     
        T Clone();
    }

    public class Car : IPrototype<Car>
    {
        public string Brand { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }

        public Car(string _brand, string _year, string _model)
        {
            Brand = _brand;
            Year = _year;
            Model = _model;
        }

        public Car Clone()
        {
            return (Car)this.MemberwiseClone();
        }

        public void GetDetails() => Console.WriteLine($"Brand : {Brand}\tYear : {Year}\tModel : {Model}");
    }
}
