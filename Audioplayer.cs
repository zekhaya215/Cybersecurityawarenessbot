using System;
using System.IO;
using System.Media;

namespace CybersecurityAwarenessBot
{
    public class AudioPlayer
    {
        private string _filePath;

        public AudioPlayer(string filePath)
        {
            _filePath = filePath;
        }

        public void Play()
        {
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _filePath);

                // Debugging line: shows where the program is looking
                Console.WriteLine("Looking for file at: " + fullPath);

                if (!File.Exists(fullPath))
                {
                    Console.WriteLine("ERROR: File not found -> " + fullPath);
                    return;
                }

                SoundPlayer player = new SoundPlayer(fullPath);
                player.PlaySync(); // Plays audio and waits until it finishes
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio error: " + ex.Message);
            }
        }
    }
}


   

     


