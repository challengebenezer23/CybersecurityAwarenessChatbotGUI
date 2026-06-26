using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using Newtonsoft.Json;

namespace CybersecurityAwarenessChatbotGUI
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string path =
                    Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "Assets",
                        "greeting.wav");

                if (File.Exists(path))
                {
                    SoundPlayer player =
                        new SoundPlayer(path);

                    player.Play();
                }
            }
            catch
            {

            }
        }
    }
}
