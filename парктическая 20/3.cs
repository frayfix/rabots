class LoginAlreadyExistsException : Exception
{
        public string Login { get; }

        public LoginAlreadyExistsException(string login)
            : base($"Логин \"1234456\" уже занят!")
        {
            Login = login;
        }
}
    class WeakPasswordException : Exception
    {
        public int PasswordLength { get; }

        public WeakPasswordException(int length)
            : base($"Ошибка: Слабый пароль! Минимум 6 символов")
        {
            PasswordLength = length;
        }
    }
    class UserService
    {
        private HashSet<string> _logins;

        public UserService()
        {
            _logins = new HashSet<string>();
        }

        public void Register(string login, string password)
        {
            Console.WriteLine("Регистрация:");
            try
            {
                if (_logins.Contains(login))
                {
                    throw new LoginAlreadyExistsException(login);
                }

                if (password.Length < 6)
                {
                    throw new WeakPasswordException(password.Length);
                }

                _logins.Add(login);
                Console.WriteLine($"Пользователь {login} успешно зарегистрирован.");
            }
            catch (LoginAlreadyExistsException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (WeakPasswordException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
class Program
{
        static void Main()
        {
            UserService uS = new UserService();
            uS.Register("admin", "123");
            uS.Register("user1", "secret123");
            uS.Register("admin", "password");
        }
}

