namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 0;

            if (lives <= 0)  //ด้านในวงเล็บ ต้องมีค่าเป็น boolean
            {
                Console.WriteLine("Game Over"); //โค้ดจะรันต่อเมื่อ if เป็นจริงเท่านั้น
            }

            //2
            int coins = 110;
            int price = 100;

            if (coins >= price)
            {
                Console.WriteLine("Purchased"); //รันเมื่อเป็นจริง
            }
            else
            {
                Console.WriteLine("Not enough coins"); //รันเมื่อเป็นเท็จ
            }

            //3
            int score = 75;

            if (score >= 90) //ลำดับ 1 เช็ค = เท็จ
            {
                Console.WriteLine("Rank S"); //โค๊ดไม่รัน ไม่อ่าน
            }
            else if (score >= 60) //ลำดับ 2 เช็ค = จริง
            {
                Console.WriteLine("Rank A"); //โค๊ดรัน
            }
            else // เป็นกรณีที่ไม่ตรงกับทั้งสอง ลำดับด้านบน มีเป็นจริงแล้ว ส่วนนี้ไม่รัน
            {
                Console.WriteLine("Rank B");
            }

            //4
            bool hasKey = true; //เผู้เล่นมีกุญแจ หรือไม่

            Console.WriteLine("your Level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);
            
            if (!ok || level < 1 || level > 99) //เช็คกรณี user  ใส่ผิด
            {
                Console.WriteLine("Invalid Level, please try again.");
            }
            else if (level >= 10 && hasKey) //ใส่เงื่อนไข 
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >=5)
            {
                Console.WriteLine("The door opens");
            }
            else
            {
                Console.WriteLine("The door stays shut");
            }

            Console.WriteLine();




            // Lab06

        }
    }
}
