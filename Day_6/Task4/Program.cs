using System;

class Program
{
    static void Main()
    {
        DataProcessor processor = new DataProcessor();
        ReportGenerator reportGen = new ReportGenerator();
        Notifier notifier = new Notifier();
        ProcessingMonitor monitor = new ProcessingMonitor();

        monitor.Setup(processor, reportGen, notifier);

        processor.StartProcessing("Финансовый отчет за Март");
    }
}
