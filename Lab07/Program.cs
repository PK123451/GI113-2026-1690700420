namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int classid = 3;

            string weapon = classid switch
            {
                1 => "Sword",
                2 => "Staff",
                3 => "Bow",
                _ => "Fists"
            };
            Console.WriteLine($"weapons {weapon}");
        }
    }
}
