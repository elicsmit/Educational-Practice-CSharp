using System;

class Program
{
    static void Main()
    {
        IMusicPlayer player = new BasicMusicPlayer();

        player = new BassBoostDecorator(player);
        player = new NoiseReductionDecorator(player);
        player = new EqualizerDecorator(player);

        Console.WriteLine($"Текущее качество: {player.GetSoundQuality()}");
    }
}
