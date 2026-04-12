using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public class Chatbot
    {
        private User _user;

        // FIXED CONSTRUCTOR
        public Chatbot(User user)
        {
            _user = user;
        }

        public void Start()
        {
            Console.Clear();
            BootSequence();
            ShowBanner();
            PlayGreeting();
            GreetUser();
            Run();
        }

        private void BootSequence()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            TypeText("Initializing system...\n");
            Pause(400);
            TypeText("Loading security modules...\n");
            Pause(400);
            TypeText("Establishing secure connection...\n");
            Pause(400);
            TypeText("Launching AI interface...\n\n");
            Pause(600);

            Console.ResetColor();
        }

        private void ShowBanner()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==================================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"   ██████╗██╗   ██╗██████╗ ███████╗██████╗ ");
            Console.WriteLine(@"  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine(@"  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝");
            Console.WriteLine(@"  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗");
            Console.WriteLine(@"  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║");
            Console.WriteLine(@"   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n        CYBERSECURITY AWARENESS BOT");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("==================================================\n");

            Console.ResetColor();
        }

        private void PlayGreeting()
        {
            try
            {
                AudioPlayer audio = new AudioPlayer("Greeting.wav");
                audio.Play();
            }
            catch
            {
                // silent fail for demo
            }
        }

        private void GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeText("Enter your name to continue: ");
            Console.ResetColor();

            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                TypeText(" Name cannot be empty. Try again: ");
                Console.ResetColor();
                name = Console.ReadLine();
            }

            // FIX: Use property instead of SetName()
            _user.Name = name;

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeText($"\nWelcome, {_user.Name}.\n");
            TypeText("AI Cybersecurity Assistant is now active.\n\n");
            Console.ResetColor();

            Pause(600);
        }

        public void Run()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("--------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeText(">> Ask a cybersecurity question (or type 'exit'): ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input.");
                    Console.ResetColor();
                    continue;
                }

                if (input == "exit")
                {
                    ExitSequence();
                    break;
                }

                ThinkingEffect();
                Respond(input);
                ShowStatus();
            }
        }

        private void ThinkingEffect()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            TypeText("\nAnalyzing input");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
        }

        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // FIXED ORDER (must start with IF)
            if (input.Contains("purpose"))
            {
                TypeText(" PURPOSE:\nThe purpose of this Cybersecurity Awareness Bot is to educate users about online threats and promote safe behavior.\n");
            }
            else if (input.Contains("phishing"))
            {
                TypeText(" ALERT: Phishing is when attackers trick you into giving sensitive information.\n");
            }
            else if (input.Contains("password"))
            {
                TypeText(" SECURITY TIP:\nUse strong passwords with symbols and numbers.\n");
            }
            else if (input.Contains("malware"))
            {
                TypeText(" WARNING:\nMalware is harmful software that damages systems.\n");
            }
            else if (input.Contains("cyber"))
            {
                TypeText(" INFO:\nCybersecurity protects systems and data from attacks.\n");
            }
            else
            {
                TypeText(" Unknown query. Try: phishing, malware, passwords.\n");
            }

            Console.ResetColor();
        }

        private void ShowStatus()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n[STATUS: SECURE | AI: ACTIVE | THREATS: MONITORED]");
            Console.ResetColor();
        }

        private void ExitSequence()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            TypeText("\nShutting down AI system...\n");
            Pause(500);
            TypeText("Disconnecting...\n");
            Pause(500);
            TypeText($"Goodbye, {_user.Name}. Stay safe online.\n");
            Console.ResetColor();
        }

        private void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
        }

        private void Pause(int ms)
        {
            Thread.Sleep(ms);
        }
    }
}
