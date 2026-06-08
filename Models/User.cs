using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace sipetok_form.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        [Browsable(false)]
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; } = new Role();
        public Status Status { get; set; } = new Status();
    }

    internal class Role
    {
        public int Key { get; set; }
        public string Label { get; set; }
    }

    internal class Status
    {
        public int Key { get; set; }
        public string Label { get; set; }
    }
}
