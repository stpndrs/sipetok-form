using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization; // Digunakan jika nama property JSON berbeda dengan C#

namespace sipetok_form.Dto.response
{
    internal class LoginResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        // Bungkus token ke dalam class LoginData di bawah
        public LoginData Data { get; set; } = new LoginData();
    }

    // Class pembantu untuk merepresentasikan objek "data" di JSON
    internal class LoginData
    {
        public string Token { get; set; } = string.Empty;
        public string Username {  get; set; } = string.Empty;
        public int Role { get; set; }
    }
}