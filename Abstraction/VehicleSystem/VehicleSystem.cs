using System;

abstract class Vehicle
{
    public abstract void Start();
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car started!");
    }
}

class Program
{
    public static void Main()
    {
        Car car = new Car();
        car.Start();
    }
}