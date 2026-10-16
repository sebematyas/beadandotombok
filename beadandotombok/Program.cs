namespace beadandotombok
{
    internal class Program
    {
        static int[] tomb = new int[10];
        static bool[] tomb2 = new bool[15];
        static int[] tomb3 = new int[5];
        static Random r = new Random();
    static void feladat1()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                int szam = r.Next(5, 11);
                tomb[i] = szam;
                Console.WriteLine($"{i+1}elem értéke {szam}");
            }
            

        }
        static void feladat2() {
            for (int i = 0; i < tomb2.Length; i++)
            {
                bool szam = Convert.ToBoolean(r.Next(0, 2));
                tomb2[i] = szam;


            }
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.WriteLine($" a {i + 1} elem =    {(tomb2[i] ? "igaz" : "hamis")}  ");

            }
        }
        static void feladat5()
        {
            for (int i = 0; i < tomb3.Length; i++)
            {
                Console.WriteLine("mongy egy szamot");
                tomb3[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < tomb3.Length; i++)
            {
                Console.WriteLine($"a {i + 1} elem = {tomb3[i]}");


            }
            for (int i = tomb3.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine($"a {i + 1} elem = {tomb3[i]}");


            }
            for (int i = 0; i < tomb3.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"a {i + 1} elem = {tomb3[i]}");
                }
            }
            int bekert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"  {bekert + 1} elem értéke  {tomb3[bekert]}");

        }
            static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat5();
        }
    }
}
