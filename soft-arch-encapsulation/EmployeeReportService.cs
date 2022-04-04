using System;

namespace soft_arch_encapsulation
{
    public class EmployeeReportService
    {
        private string _report = "";

        public void AddData(string data)
        {
            _report += data;
        }

        public void OutputReport()
        {
            Console.WriteLine(_report);
        }

        public void ClearReport()
        {
            _report = "";
        }
    }
}