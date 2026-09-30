namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;
            const string Material = "Iron";

            Console.WriteLine("------------------------------");
            Console.WriteLine("     Welcome to the Forge");
            Console.WriteLine("------------------------------");
            Console.WriteLine("=> Iron Smelting 0.25 / Salvage 0.30");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");
            Console.WriteLine();

            Console.Write("Choose Menu: ");

            bool menuOK = char.TryParse(Console.ReadLine(), out char menu);

            if (!menuOK)
            {
                Console.WriteLine("error: menu");
            }
            else
            {
                menu = char.ToUpper(menu);

                Console.Write("How much would you like: ");

                bool amountOK = double.TryParse(
                    Console.ReadLine(),
                    out double amount
                );

                if (menu == 'S' || menu == 'B')
                {
                    if (!amountOK || amount <= 0 || amount > MaxBatch)
                    {
                        if (!amountOK)
                        {
                            Console.WriteLine("error: amount (parse failed)");
                        }
                        else if (amount <= 0)
                        {
                            Console.WriteLine("error: amount (must be greater than 0)");
                        }
                        else
                        {
                            Console.WriteLine("error: amount (exceeds MaxBatch)");
                        }
                    }
                    else if (menu == 'S')
                    {
                        double ingot = amount * SmeltRate;

                        Console.WriteLine(
                            $"=> {amount:F2} {Material} Ore = {ingot:F2} {Material} Ingot"
                        );
                    }
                    else if (menu == 'B')
                    {
                        double ore = amount / SalvageRate;

                        Console.WriteLine(
                            $"=> {amount:F2} {Material} Ingot = {ore:F2} {Material} Ore"
                        );
                    }
                    else
                    {
                        Console.WriteLine("error: menu");
                    }
                }
                else
                {
                    Console.WriteLine("error: menu");
                }
            }
        }
    }
}