using System.Net.Http.Json;

namespace sipetok_form.Services.Products
{
    internal class DeleteData : IMethod
    {
        private readonly HttpClient _client;

        public DeleteData(HttpClient client)
        {
            _client = client;
        }

        private void AttachAuthHeader()
        {
            string savedToken = Properties.Settings.Default.AuthToken;
            if (!string.IsNullOrEmpty(savedToken))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
            }
        }

        // Method pertama (GET) tidak digunakan di kelas ini
        public Task<TResponse> ActionAsync<TResponse>(string endpoint)
        {
            throw new NotImplementedException("DeleteData tidak mendukung pengambilan data (GET).");
        }

        // IMPLEMENTASI UTAMA: Menangani POST dan PUT secara dinamis
        public async Task<TResponse> ActionAsync<TRequest, TResponse>(string endpoint, TRequest data, HttpMethod method)
        {
            AttachAuthHeader();
            try
            {
                HttpResponseMessage response;

                response = await _client.DeleteAsync(endpoint);

                // Baca response JSON secara generik sesuai kebutuhan target class
                var result = await response.Content.ReadFromJsonAsync<TResponse>();
                return result ?? throw new Exception("Gagal membaca respon balik dari server.");
            }
            catch (Exception ex)
            {
                throw new Exception($"[{method.Method} Error] Gagal mengirim data ke {endpoint}: {ex.Message}");
            }
        }
    }
}