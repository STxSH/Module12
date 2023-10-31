namespace Module12
{
    internal class Program
    {
        //task 12.1.5
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User("User1", "User1Name", false),
                new User("User2", "User2Name", true),
                new User("User3", "User3Name", false),
                new User("User4", "User4Name", true),
                new User("User5", "User5Name", true)
            };

            foreach (var user in users)
            {
                Console.WriteLine($"\nПриветствую, {user.Name}!");
                if (!user.IsPremium) ShowAds();
            }



        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}