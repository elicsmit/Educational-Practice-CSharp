

public class BassBoostDecorator : MusicPlayerDecorator
{
    public BassBoostDecorator(IMusicPlayer player) : base(player) { }

    public override string GetSoundQuality() => base.GetSoundQuality() + " + Усиленные басы";
}
