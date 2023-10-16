/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 16.10.2023
 * Time: 23:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace carfuel
{
			internal class Car : IVehicle
{
    public double MileAge { get; set; }
    public double Fuel { get; set; }
    public double FuelConsumption { get; set; }
    public double TankCapacity { get; set; }

    public Car(double fuel = 20, double fuelConsumption = 10, double tankCapacity = 40)
    {
        Fuel = fuel;
        FuelConsumption = fuelConsumption;
        TankCapacity = tankCapacity;
    }

    public bool Drive(double kilometers)
    {
        double requiredFuel = kilometers * FuelConsumption / 100;
        if (requiredFuel <= Fuel)
        {
            Fuel -= requiredFuel;
            MileAge += kilometers;
            return true;
        }
        return false;
    }

    public void Refuel(double amount)
    {
        if (amount > 0)
        {
            Fuel += amount;
            if (Fuel > TankCapacity)
            {
                Fuel = TankCapacity; 
            }
        }
    }

    public double GetFuel()
    {
        return Fuel;
    }

    public double GetMileage()
    {
        return MileAge;
    }
}

}
