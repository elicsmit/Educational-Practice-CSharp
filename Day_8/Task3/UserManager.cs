namespace UserManagementSystem
{
    public class UserManager<T>
    {
        private readonly IUserManager<T> _storage;

        public UserManager(IUserManager<T> storage)
        {
            _storage = storage;
        }

        public void Add(T user) => _storage.AddUser(user);

        public void Remove(T user) => _storage.RemoveUser(user);

        public void ShowUsers()
        {
            Console.WriteLine("--- Список пользователей ---");
            var users = _storage.GetAll();
            if (users.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (var user in users)
                {
                    Console.WriteLine(user.ToString());
                }
            }
        }
    }
}
