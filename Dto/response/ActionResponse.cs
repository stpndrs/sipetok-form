using System;
using System.Collections.Generic;
using sipetok_form.Models;

namespace sipetok_form.Models.dto.response
{
    internal class ActionResponse<T>
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        // Berisi data User jika sukses (bisa null jika terjadi validation error)
        public List<T>? Data { get; set; }

        // Berisi daftar error validasi jika gagal (bisa null jika sukses)
        public Dictionary<string, List<string>>? Errors { get; set; }
    }
}