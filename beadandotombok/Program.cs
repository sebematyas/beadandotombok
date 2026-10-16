namespace beadandotombok
{
    internal class Program
    {
        static int[] tomb = new int[10];
        static bool[] tomb2 = new bool[15];
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

        static void Main(string[] args)
        {
            feladat1();
            feladat2();
        }
    }
}
