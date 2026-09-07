namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");         //WriteLine พิมพ์บรรทัดใหม่, Write พิมพ์ต่อบรรทัดเดิม

            string charName = Console.ReadLine();    //เมื่อผู้เล่นกรอกชื่อ จากนั้นชื่อจะเข้าไปเก็บในตัวแปร playerName

            Console.Write("Choose a class (1-3): "); //string choice = Console.ReadLine();    //รับ input และเก็บใส่ choice
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");

            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);

            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");

            Console.WriteLine()
       
        }
    }
}
    