

public abstract class MusicPlayerDecorator : IMusicPlayer
{
    protected IMusicPlayer _player;

    public MusicPlayerDecorator(IMusicPlayer player)
    {
        _player = player;
    }

    public virtual string GetSoundQuality() => _player.GetSoundQuality();
}
