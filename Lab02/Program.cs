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



            string Name = "PK";
            char Rank = 'S';
            int Level = 10;
            int MaxHp = 250;
            float AttackPower = 45;
            double CritMultiplier = 1.75;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Rank: {Rank}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Max HP: {MaxHp}");
            Console.WriteLine($"Attack Power: {AttackPower}");
            Console.WriteLine($"Critical Multiplier: {CritMultiplier}");



            string name = "Aom";
            char RAnk = 'A';
            int LEvel = 8;
            int MAxHp = 200;
            float ATtackPower = 25;
            double CRitMultiplier = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"rank: {RAnk}");
            Console.WriteLine($"level: {LEvel}");
            Console.WriteLine($"max HP: {MAxHp}");
            Console.WriteLine($"attack power: {ATtackPower}");
            Console.WriteLine($"critical multiplier: {CRitMultiplier}");


            string name1 = "Kai";
            char rank1 = 'B';
            int level1 = 7;
            int maxHp1 = 190;
            float attackPower1 = 23;
            double critMultiplier1 = 0.9;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {name1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"Level: {level1}");
            Console.WriteLine($"Max HP: {maxHp1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier1}");


            string name2 = "Joke";
            char rank2 = 'D';
            int level2 = 5;
            int maxHp2 = 150;
            float attackPower2 = 16;
            double critMultiplier2 = 0.9;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Level: {level2}");
            Console.WriteLine($"Max HP: {maxHp2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier2}");


            string name3 = "Aon";
            char rank3 = 'F';
            int level3 = 6;
            int maxHp3 = 160;
            float attackPower3 = 15;
            double critMultiplier3 = 0.9;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Name: {name3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"Level: {level3}");
            Console.WriteLine($"Max HP: {maxHp3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier3}");


        }
    }
}
