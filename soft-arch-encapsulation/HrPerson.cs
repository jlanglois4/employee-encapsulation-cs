using System.Collections.Generic;

namespace soft_arch_encapsulation
{
    public class HrPerson
    {
        private List<Employee> _employees = new List<Employee>();
        public HrPerson()
        {
        }

        public void HireEmployee(string firstName, string lastName, string ssn)
        {
            Employee e = new Employee(firstName, lastName, ssn);
            _employees.Add(e);
            OrientEmployee(e);
        }

        private void OrientEmployee(Employee emp)
        {
            emp.DoFirstTimeOrientation("B101");
        }

        public void OutputReport(string ssn)
        {
            foreach (Employee emp in _employees)
            {
                if (emp.Ssn.Equals(ssn))
                {
                    if (emp.MetWithHr && emp.MetDeptStaff && emp.ReviewedDeptPolicies && emp.MovedIn)
                    {
                        emp.PrintReport();
                    }

                    break;
                }
            }
        }
    }
    
}