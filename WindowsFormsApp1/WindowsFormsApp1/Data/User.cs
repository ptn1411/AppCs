namespace WindowsFormsApp1.Data
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private bool remember;
        public User()
        {}

        public User(int id, string username, string password,bool remember)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.remember = remember;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool Remember
        {
            get => remember;
            set => remember = value;
        }
    }
}