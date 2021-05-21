using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis4
{
    class Account
    {
        private string user;
        private string pw;

        public Account(string user, string pw)
        {
            this.user = user;
            this.pw = pw;
        }

        public bool ValidateUser(string user, string pw)
        {
            return this.user == user && this.pw == pw;
        }

        public static bool ValidateRegistration(string user, string pw)
        {
            return false;
        }
    }
}
