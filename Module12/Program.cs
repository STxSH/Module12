namespace Module12
{
    internal class Program
    {
        //task 12.1.4
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой возраст");
            int age = int.Parse(Console.ReadLine());
            if (age > 13)
            {
                Console.WriteLine("Вы успешно зарегестрированы");
            }
            else
            {
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегестрированы");
            }
        }
    }
}