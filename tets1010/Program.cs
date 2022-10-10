namespace tets1010
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Auto a = new Auto(45, 23);
            Console.WriteLine(a);

            Console.WriteLine();

            Auto n = new NakladniAuto(80, 40, 12000);
            Console.WriteLine(n);

            Console.WriteLine();

            try
            {
                a.Dolit(3);
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(a);
            Console.WriteLine();

            Majitel m1 = new Majitel("Jan", "Novak", a);
            Majitel m2 = new Majitel("Karel", "Sykora", n);

            Console.WriteLine(m1);

            Console.WriteLine();
            Console.WriteLine(m2);
        }
    }
}