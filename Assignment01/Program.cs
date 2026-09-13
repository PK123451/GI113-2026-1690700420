namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student ID : 1690700420
            //Name       : ภัทรชนนท์ กระแสสินธุ์
            //Section    : 129A
            //Course     : GI113 Computer Programming (GI)

            const string GameTitle = "CHARACTER";

            var heroName = "PK";
            var heroRank = 'S';
            int heroLevel = 20;
            float attackPower = 45.5f;
            float critChance = 0.50f;
            double staminaPrecise = 90.7; 
            bool isPlayable = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name   : {heroName}");
            Console.WriteLine($"Rank        : {heroRank}");
            Console.WriteLine($"Level       : {heroLevel}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Chance : {critChance}");
            Console.WriteLine($"Stamina     : {staminaPrecise}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine($"=====================");

            double heroLevelAsDouble = heroLevel;
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminaTruncated = (int)staminaPrecise;
            int staminaRounded = Convert.ToInt32(staminaPrecise);
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
            Console.WriteLine($"=====================");
        }
    }
}
