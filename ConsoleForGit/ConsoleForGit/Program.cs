namespace ConsoleForGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SuperMath math = new SuperMath();
            int sumVal = math.Sum(new List<int>() { 1, 2, 3 });
            int addVal = math.Add(sumVal, 2);
            int strAddVal = math.Add(sumVal.ToString(), "2");

            if(addVal == strAddVal)
            {
                Console.WriteLine("Code works");
            }
            else
            {
                Console.WriteLine("Code failed");
            }
        }
    }
}