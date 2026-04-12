using System;

namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            User user = new User();
            Chatbot bot = new Chatbot(user);

            bot.Start();
        }
    }

    internal class User
    {
        // FIX: Proper data type
        public string Name { get; set; }

        // Constructor (optional but good)
        public User()
        {
            Name = "User";
        }

        // FIX: Implemented method instead of throwing error
        internal void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Name = "User";
            }
            else
            {
                Name = name;
            }
        }
    }
}