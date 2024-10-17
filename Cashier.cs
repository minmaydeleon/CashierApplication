namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password)
            : base(name, uName, password)
        {
            this.department = department;
        }

        public new bool validateLogin(string uName, string password)
        {
            return base.validateLogin(uName, password);
        }

        public string getDepartment()
        {
            return department;
        }
    }
}
