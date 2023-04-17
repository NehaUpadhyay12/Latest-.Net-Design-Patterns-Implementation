using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class ExcelReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}
