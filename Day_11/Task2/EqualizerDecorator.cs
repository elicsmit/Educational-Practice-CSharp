public class EqualizerDecorator : MusicPlayerDecorator
{
    public EqualizerDecorator(IMusicPlayer player) : base(player) { }

    public override string GetSoundQuality() => base.GetSoundQuality() + " + Настройка эквалайзера";
}
