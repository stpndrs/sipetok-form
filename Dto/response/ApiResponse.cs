using System;
using System.Collections.Generic;
using sipetok_form.Models;

namespace sipetok_form.Dto.response
{
    internal class ApiResponse<T>
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        // Di sini letak Array/List user yang dibungkus oleh properti "data" dari JSON
        public List<T> Data { get; set; } = new List<T>();
    }
}