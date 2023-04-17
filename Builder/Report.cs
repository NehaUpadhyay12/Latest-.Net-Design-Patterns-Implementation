using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportContent { get; set; }
        public string ReportFooter { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine($"Details of {ReportType} report are:");
            Console.WriteLine(ReportHeader); 
            Console.WriteLine(ReportContent);
            Console.WriteLine(ReportFooter);
        }
    }
}
