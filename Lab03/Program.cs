namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine($"===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"NAME: {bossName}");
            Console.WriteLine($"RANK: {rank}");
            Console.WriteLine($"LEVEL: {level}/{MaxLevel}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"ATTACK POWER: {attackPower}");
            Console.WriteLine($"CRITICAL MULTIPLIER: {critMultiplier}");
            Console.WriteLine($"IS BOSS: {isBoss}");

            // implicit conversion HP (int) -->> double
            Console.WriteLine($"\n---- Implicit Conversion: HP as double  -----");
            double currentHpAsDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpAsDouble}");

            // Calcuate Percent as double
            Console.WriteLine("\n----- Exact HP Percent (no interger truncation) -----");
            double hpPercent = currentHpAsDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercent}%");


            // Explicit casting attack power (float) -->> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            // Cas vs. Convert: Crit Multiolier
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");


        }
    }
}
