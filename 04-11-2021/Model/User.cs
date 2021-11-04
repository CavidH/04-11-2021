using System;
using System.Collections.Generic;
using System.Text;

namespace _04_11_2021.Model
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Data { get; set; }

        public User( )
        {
             
        }

        public string UserInfo()
        {
            return $"Name:{Name}\n Surname:{Surname}\nMail:{Mail}\nPassword:{Password}\nData:{Data}\n";

        }
    }
}
