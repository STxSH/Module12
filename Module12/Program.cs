namespace Module12
{
    internal class Program
    {
        //task 12.1.2
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            string greetings = $"Привет, {name}";
            Console.WriteLine(greetings);
        }
    }
}