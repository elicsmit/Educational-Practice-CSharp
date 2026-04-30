public class BackupService
{
    public void OnFileChanged(string fileName)
    {
        Console.WriteLine($"[BackupService]: Создаю резервную копию файла '{fileName}'...");
    }
}
