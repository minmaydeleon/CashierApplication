namespace UserAccountNamespace
{
    public class UserAccount
    {
        protected string user_name;
        protected string user_password;
        public string full_name;

        public UserAccount(string name, string uName, string password)
        {
            full_name = name;
            user_name = uName;
            user_password = password;
        }

        public bool validateLogin(string uName, string password)
        {
            return uName == user_name && password == user_password;
        }

        public string getFullName()
        {
            return full_name;
        }
    }
}
