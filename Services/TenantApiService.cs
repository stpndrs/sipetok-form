using sipetok_form.Dto.request;
using sipetok_form.Dto.response;
using sipetok_form.Models;
using sipetok_form.Services.Factories;
using sipetok_form.Services.Products;
using System.Diagnostics;

namespace sipetok_form.Services
{
    internal class TenantApiService
    {
        private readonly ModuleFactory _tenantFactory;

        public TenantApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _tenantFactory = new TenantFactory();
        }

        public async Task<List<Tenant>?> GetTenantsAsync()
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _tenantFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                var response = await getService.ActionAsync<ApiResponse<Tenant>>("tenants");

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ActionResponse<Tenant>> CreateTenantAsync(Tenant tenant)
        {
            try
            {
                // Minta produk "save" ke factory
                IMethod saveService = _tenantFactory.CreateMethod("save");

                var userData = new UserSaveRequest
                {
                    Username = tenant.User.Username,
                    Password = tenant.User.Password,
                    Email = tenant.User.Email,
                    Role = 2
                };

                // Bungkus body request-nya
                var requestBody = new TenantSaveRequest
                {
                    Name = tenant.Name,
                    Address = tenant.Address,
                    PhoneNumber = tenant.PhoneNumber,
                    User = userData
                };

                // Panggil ActionAsync ke-2: passing <TenantSaveRequest, ActionResponse<Tenant>>
                var result = await saveService.ActionAsync<TenantSaveRequest, ActionResponse<Tenant>>(
                    "tenants",
                    requestBody,
                    HttpMethod.Post // Tentukan methodnya POST
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Tenant> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Tenant>> UpdateTenantAsync(int id, Tenant tenant)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _tenantFactory.CreateMethod("save");

                var requestBody = new TenantSaveRequest
                {
                    Name = tenant.Name,
                    Address = tenant.Address,
                    PhoneNumber = tenant.PhoneNumber,
                    IsValid = tenant.IsValid
                };

                // Panggil ActionAsync ke-2: arahkan ke endpoint "tenants/{id}" dengan method PUT
                var result = await saveService.ActionAsync<TenantSaveRequest, ActionResponse<Tenant>>(
                    $"tenants/{id}",
                    requestBody,
                    HttpMethod.Put // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Tenant> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Tenant>> DeleteTenantAsync(int id)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod deleteService = _tenantFactory.CreateMethod("delete");
                var result = await deleteService.ActionAsync<TenantSaveRequest, ActionResponse<Tenant>>(
                    $"tenants/{id}",
                    null,
                    HttpMethod.Delete // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Tenant> { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
    }

}