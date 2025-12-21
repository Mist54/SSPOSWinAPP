using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOS.GUI.Shared
{
    public partial class SessionManager
    {
        private static string _userName;
        private static string _password;

        public static string UserName { get { return _userName; } set {_userName = value; } }
        public static string Password { get { return _password; } set { _password = value; } }

        public SessionManager()
        {
            _userName = string.Empty;
            _password = string.Empty;
        }

        public SessionManager(string Username, string password)
        {
            _userName = Username;
            _password = Password;
        }
    
    }

    
}
