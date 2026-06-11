using System.Net.Http.Json;

namespace sipetok_form.Services.Products
{
    internal class SaveData : IMethod
    {
        private readonly HttpClient _client;

        public SaveData(HttpClient client)
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
            throw new NotImplementedException("SaveData tidak mendukung pengambilan data (GET).");
        }

        // IMPLEMENTASI UTAMA: Menangani POST dan PUT secara dinamis
        public async Task<TResponse> ActionAsync<TRequest, TResponse>(string endpoint, TRequest data, HttpMethod method)
        {
            AttachAuthHeader();
            try
            {
                HttpResponseMessage response;

                // Cek secara dinamis tipe HTTP Method yang diminta
                if (method == HttpMethod.Post)
                {
                    response = await _client.PostAsJsonAsync(endpoint, data);
                }
                else if (method == HttpMethod.Put)
                {
                    response = await _client.PutAsJsonAsync(endpoint, data);
                }
                else
                {
                    throw new NotSupportedException($"HTTP Method {method} tidak didukung di SaveData.");
                }

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