using System;

namespace sipetok_form.Models.dto.request
{
    internal class UserSaveRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Diubah menjadi int agar sesuai dengan ekspektasi API Backend
        public int Role { get; set; }
        public int Status { get; set; }
    }
}