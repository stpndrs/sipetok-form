using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Json;
using sipetok_form.Models;
using sipetok_form.dto.response;

namespace sipetok_form.Services
{
    internal class ApiLaporan
    {
        private readonly HttpClient _client;
        private string _token;

        public ApiLaporan()
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
        public async Task<List<Operational>?> GetOperationalAsync()
        {
            AttachAuthHeader();
            try
            {
                var response = await _client.GetFromJsonAsync<ApiResponse<Operational>>("operationals");

                return response?.Data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Transaction>?> GetTransaksiAsync()
        {
            AttachAuthHeader();
            try
            {
                var response = await _client.GetFromJsonAsync<ApiResponse<Transaction>>("transactions");

                return response?.Data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
