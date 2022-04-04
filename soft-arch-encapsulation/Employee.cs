using System;
using Microsoft.VisualBasic;

namespace soft_arch_encapsulation
{
    public class Employee
    {
        private readonly string _requiredMsg = " is mandatory ";
        private readonly string _newline = "\n";

        public string FirstName { get; }
        public string LastName { get; }
        public string Ssn { get; }
        public bool MetWithHr { get; private set; }
        public bool MetDeptStaff { get; private set; }
        public bool ReviewedDeptPolicies { get; private set; }
        public bool MovedIn { get; private set; }
        public string CubeId { get; private set; }
        public DateTime OrientationDate { get; private set; }
        private EmployeeReportService _reportService = new EmployeeReportService();

        public Employee(string firstName, string lastName, string ssn)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("first name" + _requiredMsg);
            }
            FirstName = firstName;
            
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("last name" + _requiredMsg);
            }
            LastName = lastName;
            
            if (string.IsNullOrEmpty(ssn) || ssn.Length < 9 || ssn.Length > 11)
            {
                throw new ArgumentException("ssn" + _requiredMsg + "and must be between 9 and 11 characters (if hyphens are used)");
            }
            Ssn = ssn;
        }

        private string GetFormattedDate()
        {
            return OrientationDate.ToString("M-d-yy");
        }

        public void DoFirstTimeOrientation(string cubeId)
        {
            OrientationDate = DateTime.Now;
            MeetWithHrForBenefitAndSalaryInfo();
            MeetDepartmentStaff();
            ReviewDeptPolicies();
            MoveIntoCubicle(cubeId);
        }

        private void MeetWithHrForBenefitAndSalaryInfo()
        {
            MetWithHr = true;
            _reportService.AddData(FirstName + " " + LastName + " met with HR on " + GetFormattedDate() + _newline);
        }

        private void MeetDepartmentStaff()
        {
            MetDeptStaff = true;
            _reportService.AddData(FirstName + " " + LastName + " met with dept staff on " + GetFormattedDate() +
                                   _newline);
        }

        public void ReviewDeptPolicies()
        {
            ReviewedDeptPolicies = true;
            _reportService.AddData(FirstName + " " + LastName + " reviewed dept policies on " + GetFormattedDate() +
                                   _newline);
        }

        public void MoveIntoCubicle(string cubeId)
        {
            if (string.IsNullOrEmpty(cubeId))
            {
                throw new ArgumentException("cube id" + _requiredMsg);
            }
            CubeId = cubeId;

            MovedIn = true;
            _reportService.AddData(FirstName + " " + LastName + " moved into cubicle " + cubeId + " on " +
                                   GetFormattedDate() + _newline);
        }

        public void SetOrientationDate(DateTime orientationDate)
        {
            if (orientationDate == null)
            {
                throw new ArgumentException("orientationDate" + _requiredMsg);
            }

            OrientationDate = orientationDate;
        }

        public void PrintReport()
        {
            _reportService.OutputReport();
        }
        
        public override string ToString()
        {
            return "Employee{" + "firstName=" + FirstName + ", lastName=" + LastName + ", ssn=" + Ssn + '}';
        }
    }
}