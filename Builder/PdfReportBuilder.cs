using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PdfReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
}
