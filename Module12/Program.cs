namespace Module12
{
    internal class Program
    {
        //task 12.1.3
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = int.Parse(Console.ReadLine());
            string[] array = new string[count];
            for (int  i = 0; i < count;i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Все элементы записаны");
        }
    }
}