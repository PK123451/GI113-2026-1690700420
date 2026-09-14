namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== RXD ======");
            Console.WriteLine("PK VS AOM -- Fight Calculator ");

            //User input of Hero stats    //PK = Hero, AOM = Enemy or Monster
            Console.WriteLine("PK Health: ");
            bool ispkHp = int.TryParse(Console.ReadLine(), out int pkHp);
            Console.WriteLine("PK Attack: ");
            bool ispkAtk = int.TryParse(Console.ReadLine(), out int pkAtk);
            Console.WriteLine("PK Defence: ");
            bool ispkDef = int.TryParse(Console.ReadLine(), out int pkDef);


            //User input of Aom Stats
            Console.WriteLine("AOM Health: ");
            bool isAomHp = int.TryParse(Console.ReadLine(), out int aomHp);
            Console.WriteLine("AOM Attack: ");
            bool isAomAtk = int.TryParse(Console.ReadLine(), out int aomAtk);
            Console.WriteLine("AOM Defence: ");
            bool isAomDef = int.TryParse(Console.ReadLine(), out int aomDef);

            //Check if player input is valid
            bool allpkValid = ispkHp && ispkAtk && ispkDef;
            bool allAomValid = isAomHp && isAomAtk && isAomDef;
            Console.WriteLine($"Stats Validation : Pk: {allpkValid}, Aom: {allAomValid}");
            Console.WriteLine($"[Pk]   HP: {pkHp}, ATK: {pkAtk}, DEF: {pkDef}");
            Console.WriteLine(@$"[Aom] HP: {aomHp}, ATK: {aomAtk}, DEF: {aomDef}");

            //Before fighting: Hero drinks a potion (Compound Assignment)
            int potionHeal = 8;
            //1. pkHp = pkHp + potionHeal;
            /*2.*/pkHp += potionHeal; //แนะนำแบบนี้คำนวณเหมือนกัน 1 = 1+2
            Console.WriteLine($"\n=> PK drinks a potion, Healing {potionHeal} HP. health is now: {pkHp}.");

            // คำนวณ damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, pkAtk - aomDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");


            //คำรวณ power attack (Preaence ลำดับคำนวณ คูณ ก่อน ลบ)
            int powerDamage = Math.Max(0, pkAtk * 2 - aomDef); //เวียบลำดับ * มาก่อน - ไม่จำเป็นต้องมี ()
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            //คำนวณ Aom(Monster) Attack
            int counterDamage = Math.Max(0, aomAtk - pkDef);
            Console.WriteLine($"AOM Counter Attack deal: {counterDamage} DMG");

            //คำนวณ Cri Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // สุ่ม Cri 1-100
            bool isCritical = roll <= 10; // 10% chance
            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage; //โอกาศ 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"Critical hit roll: {roll} (critical: {isCritical})");
            Console.WriteLine($"Normail Attack would deal: {normalDamage} DMG");




        }
    }
}
