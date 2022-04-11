using System;

namespace Home_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("UserName daxil edin");
            string username = Console.ReadLine();
            Console.WriteLine("password daxil edin");
            string password = Console.ReadLine();
            User user = new User(username);
            user.Username = username;
            user.Password = password;
            
        }
    }
}
