public class FileWatcher
{
    public event FileActionHandler FileChanged;

    public void ChangeFile(string fileName)
    {
        Console.WriteLine($"[Система]: Файл '{fileName}' был изменен.");

        FileChanged?.Invoke(fileName);
    }
}
