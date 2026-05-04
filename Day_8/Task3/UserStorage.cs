namespace UserManagementSystem
{
    public class UserStorage<T> : IUserManager<T>
    {
        private List<T> _users = new List<T>();

        public void AddUser(T user)
        {
            _users.Add(user);
        }

        public void RemoveUser(T user)
        {
            _users.Remove(user);
        }

        public List<T> GetAll()
        {
            return _users;
        }
    }
}
