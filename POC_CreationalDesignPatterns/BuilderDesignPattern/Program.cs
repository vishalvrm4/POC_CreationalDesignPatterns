// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern;

Console.WriteLine("Hello, World!");

ICarBuilder carBuilder =new SUVCarBuilder();
CarDirector carDirector = new CarDirector(carBuilder);

carDirector.ConstructCar();
Car SUV = carDirector.GetCar();
SUV.ShowDetails();

carBuilder =new SedanCarBuilder();
carDirector = new CarDirector(carBuilder);

carDirector.ConstructCar();
Car sedan = carDirector.GetCar();
sedan.ShowDetails();