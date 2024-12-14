using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
            player = new SoundPlayer(musicFilePath); // Cargar el archivo de música
            player.PlayLooping();  // Reproducir en loop
            isPlaying = true;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al reproducir la música: " + ex.Message);
    }
}
