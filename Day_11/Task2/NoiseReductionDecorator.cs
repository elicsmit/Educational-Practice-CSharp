public class NoiseReductionDecorator : MusicPlayerDecorator
{
    public NoiseReductionDecorator(IMusicPlayer player) : base(player) { }

    public override string GetSoundQuality() => base.GetSoundQuality() + " + Шумоподавление";
}
