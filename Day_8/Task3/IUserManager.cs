namespace UserManagementSystem
{
    public interface IUserManager<T>
    {
        void AddUser(T user);
        void RemoveUser(T user);
        List<T> GetAll();
    }
}
