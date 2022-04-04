namespace soft_arch_encapsulation
{
    public class Company
    {
        private HrPerson _hr;

        public Company()
        {
            _hr = new HrPerson();
        }

        public void HireEmployee(string firstName, string lastName, string ssn)
        {
            _hr.HireEmployee(firstName, lastName, ssn);
            _hr.OutputReport(ssn);
        }
    }
}