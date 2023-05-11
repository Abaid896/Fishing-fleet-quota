using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingFleet.Login
{
    internal class SignUp
    {
        private string firstName;
        private string userName;
        private string password;
        private string phoneNumber;
        private string petName;
        public SignUp(string fisrtName, string userName, string password, string phoneNumber, string petName)
        {
            this.firstName = fisrtName;
            this.userName = userName;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.petName = petName;
        }
        public SignUp(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string PetName { get { return petName; } set { petName = value; } }
    }
}
