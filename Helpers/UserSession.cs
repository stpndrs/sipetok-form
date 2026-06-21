using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Helpers
{
    public static class UserSession
    {
        public static string Username { get; set; }
        public static int Role { get; set; }

        public static void Logout()
        {
            Username = null;
            Role = 0;
        }
    }
}