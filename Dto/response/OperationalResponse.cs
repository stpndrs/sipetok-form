using System;
using System.Collections.Generic;
using System.Text;

using sipetok_form.Models;

namespace sipetok_form.dto.response
{
    internal class OperationalResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        // Di sini letak Array/List operational yang dibungkus oleh properti "data" dari JSON
        public List<Operational> Data { get; set; } = new List<Operational>();
    }
}
