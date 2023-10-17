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

    public bool Drive(double kilometer)
    {
        double requiredFuel = kilometer * FuelConsumption / 100;
        if (requiredFuel <= Fuel)
        {
            Fuel -= requiredFuel;
            MileAge += kilometer;
            return true;
        }
        return false;
    }

    public void Refuel(double refueled)
    {
        if (Fuel + refueled <= TankCapacity)
        {
            Fuel += refueled;
        }
        else
        {
            Fuel = TankCapacity;
        }
    }

    public void Distance()
    {
        
    }
}

interface IDrivable
{
    bool Drive(double kilometer);
}

interface IRefuellable
{
    void Refuel(double refueled);
}

interface IVehicle : IRefuellable, IDrivable
{

}
