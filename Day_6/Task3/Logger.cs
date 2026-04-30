public class Logger
{
    public void LogChange(string fileName)
    {
        Console.WriteLine($"[Logger]: Запись в журнал: файл '{fileName}' изменен в {DateTime.Now}");
    }
}
