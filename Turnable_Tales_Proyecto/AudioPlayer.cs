using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Turnable_Tales_Proyecto
{
    internal class AudioPlayer
    {
        private static SoundPlayer player;
        private static bool isPlaying = false;

        // Método estático para iniciar o pausar la música
        public static void ToggleMusic()
        {
            string musicFilePath = @"Resources\music.wav"; // Ruta del archivo de música
            Console.WriteLine("Ruta del archivo: " + System.IO.Path.GetFullPath(musicFilePath)); // Mostrar ruta completa

            try
            {
                if (isPlaying)
                {
                    Console.WriteLine("Pausando la música...");
                    player.Stop();
                    isPlaying = false;
                }
                else
                {
                    Console.WriteLine("Reproduciendo la música...");
                    player = new SoundPlayer(musicFilePath);
                    player.PlayLooping();  // Reproducir en loop
                    isPlaying = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reproducir la música: " + ex.Message);
            }
        }
    }
}
   