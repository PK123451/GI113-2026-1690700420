namespace ทดลอง
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;
            const string Material = "Iron";

            Console.WriteLine("================================");
            Console.WriteLine("          IRON WORKSHOP");
            Console.WriteLine("================================");
            Console.WriteLine();

            Console.WriteLine("[ S ]  Smelt Ore");
            Console.WriteLine("[ B ]  Break Ingot");
            Console.WriteLine();

            Console.WriteLine($"Smelt Rate    : {SmeltRate:F2}");
            Console.WriteLine($"Break Rate    : {SalvageRate:F2}");
            Console.WriteLine($"Maximum Batch : {MaxBatch:F0}");
            Console.WriteLine();

            Console.WriteLine("--------------------------------");

            Console.Write("Select operation : ");

            bool menuOK = char.TryParse(
                Console.ReadLine(),
                out char menu
            );

            if (menuOK)
            {
                menu = char.ToUpper(menu);
            }

            Console.Write("Enter quantity   : ");

            bool amountOK = double.TryParse(
                Console.ReadLine(),
                out double amount
            );

            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            if (!menuOK || (menu != 'S' && menu != 'B'))
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("Invalid operation.");
            }
            else
            {
                if (!amountOK || amount <= 0 || amount > MaxBatch)
                {
                    Console.WriteLine("ERROR");

                    if (!amountOK)
                    {
                        Console.WriteLine("Quantity must be a number.");
                    }
                    else if (amount <= 0)
                    {
                        Console.WriteLine("Quantity must be greater than 0.");
                    }
                    else
                    {
                        Console.WriteLine(
                            $"Quantity cannot exceed {MaxBatch:F0}."
                        );
                    }
                }
                else if (menu == 'S')
                {
                    double ingot = amount * SmeltRate;

                    Console.WriteLine("          FORGING RESULT");
                    Console.WriteLine();
                    Console.WriteLine($"{amount:F2} {Material} Ore");
                    Console.WriteLine("          ↓");
                    Console.WriteLine($"{ingot:F2} {Material} Ingot");
                    Console.WriteLine();
                    Console.WriteLine(">> Smelting completed!");
                }
                else if (menu == 'B')
                {
                    double ore = amount / SalvageRate;

                    Console.WriteLine("        BREAKDOWN RESULT");
                    Console.WriteLine();
                    Console.WriteLine($"{amount:F2} {Material} Ingot");
                    Console.WriteLine("          ↓");
                    Console.WriteLine($"{ore:F2} {Material} Ore");
                    Console.WriteLine();
                    Console.WriteLine(">> Breakdown completed!");
                }
                else
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("Invalid operation.");
                }
            }

            Console.WriteLine("--------------------------------");
        }
    }
}