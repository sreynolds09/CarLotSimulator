using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public static int numberOfCars = 1;
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var car in ParkingLot)
        {Console.WriteLine($"{car.Make} {car.Model} {car.Year}");}
    }
}