using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Work
{
    internal class User
    {
        private string _userName;
        private string _password;

        public string Username
        {
            get 
            {
                return _userName; 
            }
            set
            {
              if (value.Length > 8)
              {

                _userName = value;

              }
                Console.WriteLine("Ay Yuzer 8 dene knopka bas hec olmasa)))");
            }
        }
        public User(string user)
        {
            Username = user;
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                int count = 0;
                int count1 = 0;
                int count2 = 0;
                if (value.Length >= 8)
                {

                foreach (char item in value)
                {

                if (char.IsDigit(item))
                {
                  count++;

                }
                else if (char.IsLetter(item))
                { 
                  count1++;
                }
                else if (char.IsDigit(item))
                 {

                  count2++;
                        
                 }
                        if (count && count1 && count2 > 0 )
                        {

                        }

                _password = value;
                }
                }
            }
        }
    }
}
