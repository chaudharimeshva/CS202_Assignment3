// See https://aka.ms/new-console-template for more information

using System;

class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int s, int f)
    {
        speed = s;
        fuel = f;
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving");
    }
class Car : Vehicle
{
    private int passengers;

    public Car(int s, int f, int p) : base(s, f)
    {
        passengers = p;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine($"Car is moving with {passengers} passengers.");
    }
}

// Derived class - Truck
class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int s, int f, int c) : base(s, f)
    {
        cargoWeight = c;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine($"Truck is moving with {cargoWeight} kg cargo...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed} km/h, Fuel: {fuel}, Cargo: {cargoWeight} kg");
    }
}



