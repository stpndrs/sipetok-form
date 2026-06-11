using sipetok_form.dto.request;
using sipetok_form.dto.response;
using sipetok_form.Models;
using sipetok_form.Models.dto.request;
using sipetok_form.Models.dto.response;
using sipetok_form.Services.Factories;
using sipetok_form.Services.Products;
using System.Diagnostics;

namespace sipetok_form.Services
{
    internal class ApiService
    {
        private readonly ModuleFactory _userFactory;

        public ApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _userFactory = new UserFactory();
        }

        /**
        * Auth Endpoint :
        * Login
        */
        /**
        * Auth Endpoint : Login menggunakan Factory Pattern
        */
        public async Task<LoginResponse> LoginAsync(string username, string password)
        {
            try
            {
                // 1. Minta produk "save" dari factory karena kita akan melakukan POST data
                IMethod saveService = _userFactory.CreateMethod("save");

                // 2. Siapkan payload request sesuai method asli
                var loginData = new LoginRequest { Username = username, Password = password };

                // 3. Eksekusi menggunakan ActionAsync ke-2 (passing request & response DTO)
                var result = await saveService.ActionAsync<LoginRequest, LoginResponse>(
                    "auth/login",
                    loginData,
                    HttpMethod.Post
                );

                // 4. Jalankan logika internal khusus login (simpan token jika sukses)
                if (result != null && result.Success)
                {
                    if (result.Data != null && !string.IsNullOrEmpty(result.Data.Token))
                    {
                        Properties.Settings.Default.AuthToken = result.Data.Token;
                        Properties.Settings.Default.Save();
                    }
                }

                return result ?? new LoginResponse { Success = false, Message = "Failed to login" };
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new LoginResponse { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }

        public async Task<List<User>?> GetUsersAsync()
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _userFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                var response = await getService.ActionAsync<dto.response.UserResponse>("users");

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<UserActionResponse> CreateUserAsync(User user)
        {
            try
            {
                // Minta produk "save" ke factory
                IMethod saveService = _userFactory.CreateMethod("save");

                // Bungkus body request-nya
                var requestBody = new UserSaveRequest
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Role = user.Role != null ? user.Role.Key : 0,
                    IsActive = user.IsActive?.Key == 1
                };

                // Panggil ActionAsync ke-2: passing <UserSaveRequest, UserActionResponse>
                var result = await saveService.ActionAsync<UserSaveRequest, UserActionResponse>(
                    "users",
                    requestBody,
                    HttpMethod.Post // Tentukan methodnya POST
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new UserActionResponse { Success = false, Message = ex.Message };
            }
        }

        // 2. CONTOH UNTUK UPDATE (PUT)
        public async Task<UserActionResponse> UpdateUserAsync(int id, User user)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _userFactory.CreateMethod("save");

                var requestBody = new UserSaveRequest
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Role = user.Role != null ? user.Role.Key : 0,
                    IsActive = user.IsActive?.Key == 1
                };

                // Panggil ActionAsync ke-2: arahkan ke endpoint "users/{id}" dengan method PUT
                var result = await saveService.ActionAsync<UserSaveRequest, UserActionResponse>(
                    $"users/{id}",
                    requestBody,
                    HttpMethod.Put // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new UserActionResponse { Success = false, Message = ex.Message };
            }
        }

        public async Task<UserActionResponse> DeleteUserAsync(int id)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod deleteService = _userFactory.CreateMethod("delete");
                var result = await deleteService.ActionAsync<UserSaveRequest, UserActionResponse>(
                    $"users/{id}",
                    null,
                    HttpMethod.Delete // Tentukan methodnya PUT
                );

                return result;

                return result ?? new UserActionResponse
                {
                    Success = false,
                    Message = "Failed to delete data"
                };
            }
            catch (Exception ex)
            {
                return new UserActionResponse { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
    }
}