using sipetok_form.dto.request;
using sipetok_form.dto.response;
using sipetok_form.Helpers;
using sipetok_form.Models;
using sipetok_form.Models.dto.request;
using sipetok_form.Models.dto.response;
using sipetok_form.Services.Factories;
using sipetok_form.Services.Products;
using System.Diagnostics;

namespace sipetok_form.Services
{
    internal class AuthApiService
    {
        private readonly ModuleFactory _authFactory;

        public AuthApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _authFactory = new AuthFactory();
        }

        public async Task<LoginResponse> LoginAsync(string username, string password)
        {
            try
            {
                // 1. Minta produk "save" dari factory karena kita akan melakukan POST data
                IMethod saveService = _authFactory.CreateMethod("save");

                // 2. Siapkan payload request sesuai method asli
                var request = new LoginRequest { Username = username, Password = password };

                // 3. Eksekusi menggunakan ActionAsync ke-2 (passing request & response DTO)
                var response = await saveService.ActionAsync<LoginRequest, LoginResponse>(
                    "auth/login",
                    request,
                    HttpMethod.Post
                );

                // 4. Jalankan logika internal khusus login (simpan token jika sukses)
                if (response != null && response.Success)
                {
                    if (response.Data != null && !string.IsNullOrEmpty(response.Data.Token))
                    {
                        Properties.Settings.Default.AuthToken = response.Data.Token;
                        Properties.Settings.Default.Save();
                    }

                    if (response.Data != null && !string.IsNullOrEmpty(response.Data.Username) && response.Data.Role != 0)
                    {
                        UserSession.Username = response.Data.Username;
                        UserSession.Role = response.Data.Role;
                    }
                }

                return response ?? new LoginResponse { Success = false, Message = "Failed to login" };
            }
            catch (Exception ex)
            {
                return new LoginResponse { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
    }

}