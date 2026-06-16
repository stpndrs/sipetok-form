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
    internal class UserApiService
    {
        private readonly ModuleFactory _userFactory;

        public UserApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _userFactory = new UserFactory();
        }

        public async Task<List<User>?> GetUsersAsync()
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _userFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                var response = await getService.ActionAsync<dto.response.ApiResponse<User>>("users");

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ActionResponse<User>> CreateUserAsync(User user)
        {
            try
            {
                // Minta produk "save" ke factory
                IMethod saveService = _userFactory.CreateMethod("save");

                // Bungkus body request-nya
                var request = new UserSaveRequest
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Role = user.Role != null ? user.Role.Key : 0,
                    IsActive = user.IsActive?.Key == 1
                };

                // Panggil ActionAsync ke-2: passing <UserSaveRequest, ActionResponse<User>>
                var response = await saveService.ActionAsync<UserSaveRequest, ActionResponse<User>>(
                    "users",
                    request,
                    HttpMethod.Post // Tentukan methodnya POST
                );

                return response;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<User> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<User>> UpdateUserAsync(int id, User user)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _userFactory.CreateMethod("save");

                var request = new UserSaveRequest
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Role = user.Role != null ? user.Role.Key : 0,
                    IsActive = user.IsActive?.Key == 1
                };

                // Panggil ActionAsync ke-2: arahkan ke endpoint "users/{id}" dengan method PUT
                var response = await saveService.ActionAsync<UserSaveRequest, ActionResponse<User>>(
                    $"users/{id}",
                    request,
                    HttpMethod.Put // Tentukan methodnya PUT
                );

                return response;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<User> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<User>> DeleteUserAsync(int id)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod deleteService = _userFactory.CreateMethod("delete");
                var response = await deleteService.ActionAsync<UserSaveRequest, ActionResponse<User>>(
                    $"users/{id}",
                    null,
                    HttpMethod.Delete // Tentukan methodnya PUT
                );

                return response;
            }
            catch (Exception ex)
            {
                return new ActionResponse<User> { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
    }

}