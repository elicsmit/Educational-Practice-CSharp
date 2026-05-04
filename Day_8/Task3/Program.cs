using System;
using System.Collections.Generic;

namespace UserManagementSystem
{

    class Program
    {
        static void Main()
        {
            var storage = new UserStorage<User>();
            var manager = new UserManager<User>(storage);

            manager.Add(new User("Admin_Dmitry", "Администратор"));
            manager.Add(new User("User_Anna", "Клиент"));
            manager.Add(new User("Support_Ivan", "Поддержка"));

            manager.ShowUsers();

            Console.WriteLine("\nУдаляем одного пользователя...");
            
            var tempUser = new User("Test", "Guest");
            manager.Add(tempUser);
            manager.Remove(tempUser);

            manager.ShowUsers();

            Console.ReadKey();
        }
    }
}
