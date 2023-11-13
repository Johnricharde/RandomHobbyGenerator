namespace RandomHobbyGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            askForName();
            Console.ReadKey();
        }
        static void askForName()
        {
            Console.WriteLine("Tell me your name and I'll assign you a new hobby.");
            String userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}!\nYou should try out {RandomHobby()}!\n");
            askForName();
        }
        static string RandomHobby()
        {

            Random rand = new Random();
            var randomNumber = rand.Next(0,3);

            if (randomNumber == 0) {
                return "knitting";
            }
            else if (randomNumber == 1) {
                return "stamp collecting";
            }
            else
            {
                return "extreme rockclimbing";
            }
        }
    }
}