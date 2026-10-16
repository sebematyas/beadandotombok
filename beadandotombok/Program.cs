namespace beadandotombok
{
    internal class Program
    {
        static int[] tomb = new int[10];
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

        static void Main(string[] args)
        {
            feladat1();
        }
    }
}
