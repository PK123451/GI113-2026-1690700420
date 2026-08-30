/*
 * Student ID : 1690700420
 * Name       : ภัทรชนนท์ กระแสสินธุ์
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */



namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("-- BOSS STATUS: INITIAL --");
            Console.WriteLine($"Boss Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
           
            int hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"IS BOSS: {isBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent: {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damge!");
            Console.WriteLine();
            Console.WriteLine($"-- BOSS STATUS: AFTER DAMAGE --");
            Console.WriteLine($"HP: { currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: 47%");


        }
    }
}
