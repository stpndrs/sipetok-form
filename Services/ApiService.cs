using sipetok_form.dto.request;
using sipetok_form.dto.response;
using sipetok_form.Models;
using sipetok_form.Models.dto.request;
using sipetok_form.Models.dto.response;
using System.Diagnostics;
using System.Net.Http.Json;

namespace sipetok_form.Services
{
    internal class ApiService
    {
        private readonly HttpClient _client;
        private string _token;

        public ApiService()
        {
            _client = new HttpClient { BaseAddress = new Uri("http://localhost:5062/api/") };
        }

        private void AttachAuthHeader()
        {
            string savedToken = sipetok_form.Properties.Settings.Default.AuthToken;
            if (!string.IsNullOrEmpty(savedToken))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
            }
        }

        /**
        * Auth Endpoint :
        * Login
        */
        public async Task<LoginResponse> LoginAsync(string username, string password)
        {
            try
            {
                var loginData = new LoginRequest { Username = username, Password = password };
                var response = await _client.PostAsJsonAsync("auth/login", loginData);

                var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
                if (result.Success)
                {
                    if (result != null && !string.IsNullOrEmpty(result.Data.Token))
                    {
                        sipetok_form.Properties.Settings.Default.AuthToken = result.Data.Token;
                        sipetok_form.Properties.Settings.Default.Save();
                    }
                }
                return result ?? new LoginResponse { Success = false, Message = "Failed to login" };
            }
            catch (Exception ex)
            {
                return new LoginResponse { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }

        /**
        * User Endpoint :
        * Get
        * Create
        * Update
        * Delete
        */
        public async Task<List<User>?> GetUsersAsync()
        {
            AttachAuthHeader();
            try
            {
                var response = await _client.GetFromJsonAsync<sipetok_form.dto.response.UserResponse>("users");

                return response?.Data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<UserActionResponse> CreateProductAsync(User user)
        {
            AttachAuthHeader();
            try
            {
                var requestBody = new UserSaveRequest
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Role = user.Role != null ? user.Role.Key : 0,
                    Status = user.Status != null ? user.Status.Key : 0
                };

                var response = await _client.PostAsJsonAsync("users", requestBody);
                var result = await response.Content.ReadFromJsonAsync<UserActionResponse>();

                return result ?? new UserActionResponse { Success = false, Message = "Failed to create data" };
            }
            catch (Exception ex)
            {
                return new UserActionResponse { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
        public async Task<UserActionResponse> UpdateUserAsync(int id, User user)
        {
            AttachAuthHeader();
            try
            {
                var requestBody = new UserSaveRequest
                {
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Role = user.Role != null ? user.Role.Key : 0,
                    Status = user.Status != null ? user.Status.Key : 0
                };

                var response = await _client.PutAsJsonAsync($"users/{id}", requestBody);
                var result = await response.Content.ReadFromJsonAsync<UserActionResponse>();

                return result ?? new UserActionResponse { Success = false, Message = "Failed to update data" };
            }
            catch (Exception ex)
            {
                return new UserActionResponse { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
        public async Task<UserActionResponse> DeleteUserAsync(int id)
        {
            AttachAuthHeader();
            try
            {
                var response = await _client.DeleteAsync($"users/{id}");
                var result = await response.Content.ReadFromJsonAsync<UserActionResponse>();

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

        /**
        * Tambahkan endpoint lainnya dibawah sini
        */
    }
}