public class ProcessingMonitor
{
    public void Setup(DataProcessor processor, ReportGenerator reportGen, Notifier notifier)
    {
        processor.ProcessingCompleted += reportGen.CreateReport;
        processor.ProcessingCompleted += notifier.SendNotification;

        Console.WriteLine("[Monitor]: Подписки настроены.");
    }
}
