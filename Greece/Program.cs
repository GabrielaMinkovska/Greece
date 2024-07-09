namespace Greece
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();
                string[] destinations = { "Rhodes", "Kefalonia", "Try again" };
                string selectedDestination = "";
                string userInput = "";

                while (selectedDestination != "Rhodes" && selectedDestination != "Kefalonia")
                {
                    Console.WriteLine("Please type: 'Where are we going on vacation in Greece?'");
                    userInput = Console.ReadLine();

                    if (userInput == "Where are we going on vacation in Greece?")
                    {
                        selectedDestination = destinations[random.Next(destinations.Length)];
                        Console.WriteLine(selectedDestination);
                    }
                }

                Console.WriteLine($"Great! We are going to {selectedDestination}!");
            }
        }
    }
}