namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Hi Kal";    // ขีดด้านล่าง bossName คือยังไม่เคยใช้
            char rank = '7';               // char เป้นตัวอักษร 1 ตัว
            int level = 7;                 // int เป็นจำนวนเต็ม ใส่ได้แค่ เต็มบวก, เต็มลบ, 0
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;     // float เป็นตัวเลขทศนิยม ต้องเติม f ต่อท้าย
            double critMultitplier = 1.75; // double เป็นเลขทศนิยม ที่เก็บได้หลายหลักกว่า float (ไม่ต้องเติม f )
            bool isBoss = true;            // bool เป็นเงือนไข ใส่ true, false มีค่าด้านในเป็น 0, 1
            

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"HP: {currentHp / maxHp * 100}%");
        }
    }
}
