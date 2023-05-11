using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingFleet.Login
{
    internal class Login
    {
        private string userName;
        private string password;
        private string newPassword;
        public Login(string userName, string password, string newPassword)
        {
            Username = userName;
            Password = password;
            NewPassword = newPassword;
        }
        public Login(string userName, string password)
        {
            Username = userName;
            Password = password;
        }
        public string Username { get { return userName; } set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string NewPassword { get { return newPassword; } set { newPassword = value; } }
    }
}
