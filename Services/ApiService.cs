namespace sipetok_form.Services
{
    internal class ApiService
    {
        public AuthApiService Auth { get; }
        public UserApiService User { get; }
        public ApiService()
        {
            Auth = new AuthApiService();
            User = new UserApiService();
        }
    }
}