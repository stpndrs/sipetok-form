using System.Net.Http.Json;
using sipetok_form.Helpers;

namespace sipetok_form.Services.Products
{
    internal class GetData : IMethod
    {
        private readonly HttpClient _client;

        public GetData(HttpClient client)
        {
            _client = client;
        }

        // Implementasi untuk GET data
        public async Task<TResponse> ActionAsync<TResponse>(string endpoint)
        {
            AuthHelper.AttachAuthHeader(_client);
            try
            {
                var response = await _client.GetFromJsonAsync<TResponse>(endpoint);
                return response ?? throw new Exception("Gagal membaca respon atau data kosong.");
            }
            catch (Exception ex)
            {
                throw new Exception($"[GET Error] Gagal terhubung ke {endpoint}: {ex.Message}");
            }
        }

        // Method ini tidak digunakan di GetData, bisa dilempar exception atau dikosongkan
        public async Task<TResponse> ActionAsync<TRequest, TResponse>(string endpoint, TRequest data, HttpMethod method)
        {
            throw new NotImplementedException("GetData tidak mendukung pengiriman payload body.");
        }
    }
}