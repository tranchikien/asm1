using System;

class WaterBillCalculator
{
    static void Main(string[] args)
    {
        string customerName = GetCustomerName();
        double lastMonthReading = GetReading("Enter last month's water meter reading: ");
        double thisMonthReading = GetReading("Enter this month's water meter reading: ");

        if (thisMonthReading < lastMonthReading)
        {
            Console.WriteLine("Error: This month's meter reading must be greater than or equal to last month's reading.");
            return;
        }

        string customerType = GetCustomerType();
        double consumption = thisMonthReading - lastMonthReading;
        double totalBill = CalculateTotalBill(customerType, consumption);
        double environmentFee = CalculateEnvironmentFee(totalBill);
        double subTotal = totalBill + environmentFee; // Including environment protection fee
        double VAT = CalculateVAT(subTotal); // Calculating 10% VAT
        double finalTotal = subTotal + VAT; // Total bill including VAT

        PrintBill(customerName, lastMonthReading, thisMonthReading, consumption, finalTotal);
    }

    static string GetCustomerName()
    {
        Console.Write("Enter customer name: ");
        return Console.ReadLine();
    }

    static double GetReading(string prompt)
    {
        double reading;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out reading) || reading < 0)
        {
            Console.WriteLine("Please enter a non-negative number.");
            Console.Write(prompt);
        }
        return reading;
    }

    static string GetCustomerType()
    {
        Console.WriteLine("List customer type:");
        Console.WriteLine("1. Household");
        Console.WriteLine("2. Administrative");
        Console.WriteLine("3. Production");
        Console.WriteLine("4. Business");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid choice. Please select again:");
            Console.WriteLine("1. Household");
            Console.WriteLine("2. Administrative");
            Console.WriteLine("3. Production");
            Console.WriteLine("4. Business");
        }

        switch (choice)
        {
            case 1:
                return "household";
            case 2:
                return "administrative";
            case 3:
                return "production";
            case 4:
                return "business";
            default:
                return "household"; // Default case if an error occurs
        }
    }

    static double CalculateTotalBill(string customerType, double consumption)
    {
        double totalBill = 0;
        if (customerType == "household")
        {
            Console.Write("Enter number of people in household: ");
            int numberOfPeople;
            while (!int.TryParse(Console.ReadLine(), out numberOfPeople) || numberOfPeople <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                Console.Write("Enter number of people in household: ");
            }

            double perPersonConsumption = consumption / numberOfPeople;

            if (perPersonConsumption <= 10)
            {
                totalBill = consumption * 5973;
            }
            else if (perPersonConsumption <= 20)
            {
                totalBill = consumption * 7052;
            }
            else if (perPersonConsumption <= 30)
            {
                totalBill = consumption * 8699;
            }
            else
            {
                totalBill = consumption * 15929;
            }
        }
        else if (customerType == "administrative")
        {
            totalBill = consumption * 9955;
        }
        else if (customerType == "production")
        {
            totalBill = consumption * 11615;
        }
        else if (customerType == "business")
        {
            totalBill = consumption * 22068;
        }
        return totalBill;
    }

    static double CalculateEnvironmentFee(double totalBill)
    {
        return totalBill * 0.1;
    }

    static double CalculateVAT(double subTotal)
    {
        return subTotal * 0.1;
    }

    static void PrintBill(string customerName, double lastMonthReading, double thisMonthReading, double consumption, double finalTotal)
    {
        Console.WriteLine($"Customer name: {customerName}");
        Console.WriteLine($"Last month's water meter reading: {lastMonthReading}");
        Console.WriteLine($"This month's water meter reading: {thisMonthReading}");
        Console.WriteLine($"Consumption: {consumption} m3");
        Console.WriteLine($"Total water bill (including environment protection fee and VAT): {finalTotal} VND");
    }
}

