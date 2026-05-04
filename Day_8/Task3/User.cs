namespace UserManagementSystem
{
    
    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public User(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public override string ToString() => $"Пользователь: {Name} (Роль: {Role})";
    }
}
