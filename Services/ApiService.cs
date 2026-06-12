namespace sipetok_form.Services
{
    internal class ApiService
    {
        public AuthApiService Auth { get; }
        public UserApiService User { get; }
        public TenantApiService Tenant { get; }
        public OperationalApiService Operational { get; }
        public EggCategoryApiService EggCategory { get; }
        public EggApiService Egg { get; }
        public TransactionApiService Transaction { get; }
        public ApiService()
        {
            Auth = new AuthApiService();
            User = new UserApiService();
            Tenant = new TenantApiService();
            Operational = new OperationalApiService();
            EggCategory = new EggCategoryApiService();
            Egg = new EggApiService();
            Transaction = new TransactionApiService();
        }
    }
}