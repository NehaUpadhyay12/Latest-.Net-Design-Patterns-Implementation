namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportDirector reportDirector = new ReportDirector();
            PdfReportBuilder pdfReportBuilder = new PdfReportBuilder();
            Report report = reportDirector.MakeReport(pdfReportBuilder);
            report.DisplayReport();
            report = reportDirector.MakeReport(new ExcelReportBuilder());
            report.DisplayReport();
        }
    }
}