public class Notifier
{
    public void SendNotification(object sender, ProcessingEventArgs e)
    {
        Console.WriteLine($"[Notifier]: Уведомление: обработка '{e.DataName}' завершена.");
    }
}
