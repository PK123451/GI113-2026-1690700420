/*
* Student ID : 1690700420
* Name       : ภัทรชนนท์ กระแสสินธุ์
* Section    : 129A
* No.        : 23
* Course     : GI113 Computer Programming (GI)
*/


namespace Lab06._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "PK";
            char rank = 'S';
            int level = 5;
            int hp = 120;
            float attackPower = 20;

            Console.WriteLine("===== PLAYER STATUS =====");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Attack: {attackPower}");
            Console.WriteLine("=========================");
            Console.WriteLine();

            string enemyName = "Dark Slime";
            char enemyRank = 'B';
            int enemyLevel = 10;
            int enemyHP = 150;
            float enemyAttackPower = 10;

            Console.WriteLine("===== ENEMY STATUS =====");
            Console.WriteLine($"Name: {enemyName}");
            Console.WriteLine($"Rank: {enemyRank}");
            Console.WriteLine($"Level: {enemyLevel}");
            Console.WriteLine($"HP: {enemyHP}");
            Console.WriteLine($"Attack: {enemyAttackPower}");
            Console.WriteLine("=========================");
            Console.WriteLine();

            Console.WriteLine("===== PLAYER TURN =====");
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Heal");
            Console.WriteLine("[3] Flee");
            Console.Write("Choose your action: ");

            bool validChoice = int.TryParse(
                Console.ReadLine(), out int choice);

            if (!validChoice || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (choice == 1)
            {
                Console.WriteLine("You attack the Dark Slime!");
                enemyHP -= (int)attackPower;

                if (enemyHP < 0)
                {
                    enemyHP = 0;
                }

                Console.WriteLine($"Damage dealt: {attackPower}");
                Console.WriteLine($"Enemy HP: {enemyHP}");

                if (enemyHP == 0)
                {
                    Console.WriteLine("You defeated the enemy!");
                }
                else
                {
                    Console.WriteLine("The enemy is still alive!");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter heal amount: ");

                bool validHeal = int.TryParse(
                    Console.ReadLine(), out int heal);

                if (!validHeal || heal <= 0)
                {
                    Console.WriteLine("Invalid heal amount!");
                }
                else if (hp >= 120)
                {
                    Console.WriteLine("HP is already full!");
                }
                else
                {
                    hp += heal;

                    if (hp > 120)
                    {
                        hp = 120;
                    }

                    Console.WriteLine("You healed yourself!");
                    Console.WriteLine($"Current HP: {hp}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("You escaped from the battle!");
            }

            Console.WriteLine("=========================");
        }
    }
}
