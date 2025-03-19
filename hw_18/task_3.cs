using System;
using System.Collections;
using System.Collections.Generic;

class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"Model: {Model}, Year: {Year}";
    }
}

class Garage : IEnumerable<Car>
{
    private List<Car> cars;

    public Garage(List<Car> cars)
    {
        this.cars = cars;
    }

    public IEnumerator<Car> GetEnumerator()
    {
        foreach (var car in cars)
        {
            yield return car;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void RemoveCar(int index)
    {
        if (index >= 0 && index < cars.Count)
        {
            cars.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index!");
        }
    }

    public void DisplayCars()
    {
        Console.WriteLine("Cars currently in the garage:");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}

class Program
{
    static void Main()
    {
        Garage garage = new Garage(new List<Car>
        {
            new Car("Toyota Corolla", 2020),
            new Car("BMW X5", 2018),
            new Car("Audi A6", 2022),
            new Car("Mercedes-Benz C-Class", 2021)
        });

        foreach (var car in garage)
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("\nAdding a new car");
        garage.AddCar(new Car("Honda Civic", 2019));
        garage.DisplayCars();

        Console.WriteLine("\nRemoving car at index 2");
        garage.RemoveCar(2);
        garage.DisplayCars();
    }
}
 