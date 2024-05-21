// See https://aka.ms/new-console-template for more information
using PrototypeDesignPattern;

Console.WriteLine("Hello, World!");


Car carSedan = new Car("Honda", "2022", "Sedan");
carSedan.GetDetails();

// clone
Car carHatchback = carSedan.Clone();
carHatchback.Model = "Hatchback";
carHatchback.GetDetails();

if (carHatchback == carSedan)
    Console.WriteLine("Both object same");