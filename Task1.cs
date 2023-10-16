class Program
{
    public static void Main(string[] args)
    {
        bool check = true;
        Car myCar = new Car();

        Console.WriteLine("Remaining Fuel is " + myCar.GetFuel() + " liters");
        Console.WriteLine("Total capacity is " + myCar.TankCapacity + " liters");
        Console.WriteLine("Fuel consumed per kilometer is " + myCar.FuelConsumption + " liters");

        while (check)
        {
            Console.WriteLine("1. Drive");
            Console.WriteLine("2. Refuel");
            Console.WriteLine("3. Display fuel");
            Console.WriteLine("4. Display distance");
            Console.WriteLine("5. Exit");

            Console.WriteLine("");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            switch (choice)
            {
                case "1":
                    Console.Write("How many kilometers are you planning to drive? ");
                    if (double.TryParse(Console.ReadLine(), out double kilometers))
                    {
                        if (myCar.Drive(kilometers))
                        {
                            Console.WriteLine("You drove " + kilometers + " kilometers.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to drive that far.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number of kilometers.");
                    }
                    break;
                case "2":
                    Console.Write("How much fuel do you want to add? ");
                    if (double.TryParse(Console.ReadLine(), out double fuelToAdd))
                    {
                        myCar.Refuel(fuelToAdd);
                        Console.WriteLine("Fuel added. Current fuel: " + myCar.GetFuel() + " liters");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount of fuel.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Current Fuel: " + myCar.GetFuel() + " liters");
                    break;
                case "4":
                    Console.WriteLine("Distance Traveled: " + myCar.GetMileage() + " km");
                    break;
                case "5":
                    check = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
