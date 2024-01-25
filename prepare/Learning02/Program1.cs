using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        int count = 23;
        var car = new List<Car>();
        
        var car = new Car();
        car.make = "Honda";
        car.model = "Civic";
        car.year = 2021
        car.gallons = 10;
        car.milesPerGallon = 30;

        var owner = new Person();
        Owner.name = "Bob";
        owner.phone = "333-3333";
        car.owner = owner;

        cars.Add(car);

        car = new Car();
        car.make = "Ford";
        car.model = "F-150";
        car.year = 2023
        car.gallons = 30;
        car.milesPerGallon = 5;

        var owner = new Person();
        Owner.name = "Sue";
        owner.phone = "444-4444";
        car.owner = owner;

        cars.Add(car);

        Console.Clear();
        foreach(var c in cars) {
            // System.Console.WriteLine($"{c.make} {c.model} {c.gallons} gallons {c.milesPerGallon}mpg": TotalRange = {c.TotalRange()});
            c.Display();
        }
    }
}