namespace sipetok_form.Helpers
{
    internal class AuthHelper
    {
        public static void AttachAuthHeader(HttpClient _client)
        {
            string savedToken = Properties.Settings.Default.AuthToken;
            if (!string.IsNullOrEmpty(savedToken))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
            }
        }
    }
}