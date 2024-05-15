namespace csqaralama;


partial class Program
{
    public class LoginFailedException : Exception
    {
        public LoginFailedException(string message) : base(message)
        {
        }
    }
    public class User 
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void Login(string enteredUsername, string enteredPassword)
        {
            if (enteredUsername != username || enteredPassword != password)
            {
                throw new LoginFailedException("Invalid username or password.");
            }
            else
            {
                Console.WriteLine("Login successful!");
            }
        }
    }
}

