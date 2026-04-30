using System;

public delegate void FileActionHandler(string fileName);

class Program
{
    static void Main()
    {
        FileWatcher watcher = new FileWatcher();
        BackupService backup = new BackupService();
        Logger logger = new Logger();

        watcher.FileChanged += backup.OnFileChanged;
        watcher.FileChanged += logger.LogChange;

        watcher.ChangeFile("document.docx");

        Console.WriteLine("\n--- После отписки логгера ---");
        watcher.FileChanged -= logger.LogChange;

        watcher.ChangeFile("data.txt");
    }
}
