using System;
using System.Collections.Generic;
using sipetok_form.Models;

namespace sipetok_form.dto.response
{
    internal class UserResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        // Di sini letak Array/List user yang dibungkus oleh properti "data" dari JSON
        public List<User> Data { get; set; } = new List<User>();
    }
}