public class DataProcessor
{
    public event EventHandler<ProcessingEventArgs> ProcessingCompleted;

    public void StartProcessing(string name)
    {
        Console.WriteLine($"[DataProcessor]: Начата обработка данных: {name}...");
        
        System.Threading.Thread.Sleep(1000);

        OnProcessingCompleted(new ProcessingEventArgs { DataName = name });
    }

    protected virtual void OnProcessingCompleted(ProcessingEventArgs e)
    {
        ProcessingCompleted?.Invoke(this, e);
    }
}
