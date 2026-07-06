using sipetok_form.Dto.request;
using sipetok_form.Dto.response;
using sipetok_form.Models;
using sipetok_form.Services.Factories;
using sipetok_form.Services.Products;
using System.Diagnostics;

namespace sipetok_form.Services
{
    internal class OperationalApiService
    {
        private readonly ModuleFactory _tenantFactory;

        public OperationalApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _tenantFactory = new OperationalFactory();
        }

        public async Task<List<Operational>?> GetOperationalsAsync()
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _tenantFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                var response = await getService.ActionAsync<ApiResponse<Operational>>("operationals");

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ActionResponse<Operational>> CreateOperationalAsync(Operational operational)
        {
            try
            {
                // Minta produk "save" ke factory
                IMethod saveService = _tenantFactory.CreateMethod("save");

                // Bungkus body request-nya
                var requestBody = new OperationalSaveRequest
                {
                    Name = operational.Name,
                    OperationalCost = operational.OperationalCost,
                    TenantId = operational.TenantId,
                    OperationalDate = operational.OperationalDate,
                };

                // Panggil ActionAsync ke-2: passing <OperationalSaveRequest, ActionResponse<Operational>>
                var result = await saveService.ActionAsync<OperationalSaveRequest, ActionResponse<Operational>>(
                    "operationals",
                    requestBody,
                    HttpMethod.Post // Tentukan methodnya POST
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Operational> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Operational>> UpdateOperationalAsync(int id, Operational operational)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _tenantFactory.CreateMethod("save");

                var requestBody = new OperationalSaveRequest
                {
                    Name = operational.Name,
                    OperationalCost = operational.OperationalCost,
                    TenantId = operational.TenantId,
                    OperationalDate = operational.OperationalDate,
                };

                // Panggil ActionAsync ke-2: arahkan ke endpoint "operationals/{id}" dengan method PUT
                var result = await saveService.ActionAsync<OperationalSaveRequest, ActionResponse<Operational>>(
                    $"operationals/{id}",
                    requestBody,
                    HttpMethod.Put // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Operational> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Operational>> DeleteOperationalAsync(int id)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod deleteService = _tenantFactory.CreateMethod("delete");
                var result = await deleteService.ActionAsync<OperationalSaveRequest, ActionResponse<Operational>>(
                    $"operationals/{id}",
                    null,
                    HttpMethod.Delete // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Operational> { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
    }

}