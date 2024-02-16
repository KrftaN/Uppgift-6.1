namespace Uppgift_6._1
{
    class Program
    {
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tre tal separerade med kommatecken [1, 2, 3]");
            int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            int sum = Addera(numbers[0], numbers[1], numbers[2]);
            Console.WriteLine($"Summan av talen {numbers[0]}, {numbers[1]}, {numbers[2]} är: {sum}");
        }
    }
}