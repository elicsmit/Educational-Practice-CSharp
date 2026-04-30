public class ReportGenerator
{
    public void CreateReport(object sender, ProcessingEventArgs e)
    {
        Console.WriteLine($"[ReportGenerator]: Отчет по данным '{e.DataName}' успешно сформирован.");
    }
}
