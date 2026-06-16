using sipetok_form.dto.request;
using sipetok_form.dto.response;
using sipetok_form.Models;
using sipetok_form.Models.dto.request;
using sipetok_form.Models.dto.response;
using sipetok_form.Services.Factories;
using sipetok_form.Services.Products;
using System.Diagnostics;

namespace sipetok_form.Services
{
    internal class EggApiService
    {
        private readonly ModuleFactory _eggFactory;


        public EggApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _eggFactory = new EggFactory();
        }

        public async Task<List<Egg>?> GetEggsAsync()
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _eggFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                var response = await getService.ActionAsync<dto.response.ApiResponse<Egg>>("eggs");

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ActionResponse<Egg>> CreateEggAsync(Egg egg)
        {
            try
            {
                // Minta produk "save" ke factory
                IMethod saveService = _eggFactory.CreateMethod("save");

                // Bungkus body request-nya
                var requestBody = new EggSaveRequest
                {
                    ProductionDate = egg.ProductionDate,
                    Stock = egg.Stock,
                    CategoryId = egg.CategoryId
                };

                // Panggil ActionAsync ke-2: passing <EggSaveRequest, ActionResponse<Egg>>
                var result = await saveService.ActionAsync<EggSaveRequest, ActionResponse<Egg>>(
                    "eggs",
                    requestBody,
                    HttpMethod.Post // Tentukan methodnya POST
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Egg> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Egg>> UpdateEggAsync(int id, Egg egg)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _eggFactory.CreateMethod("save");

                var requestBody = new EggSaveRequest
                {
                    ProductionDate = egg.ProductionDate,
                    Stock = egg.Stock,
                    CategoryId = egg.CategoryId
                };

                // Panggil ActionAsync ke-2: arahkan ke endpoint "egg/categories/{id}" dengan method PUT
                var result = await saveService.ActionAsync<EggSaveRequest, ActionResponse<Egg>>(
                    $"eggs/{id}",
                    requestBody,
                    HttpMethod.Put // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Egg> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Egg>> DeleteEggAsync(int id)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod deleteService = _eggFactory.CreateMethod("delete");
                var result = await deleteService.ActionAsync<EggSaveRequest, ActionResponse<Egg>>(
                    $"eggs/{id}",
                    null,
                    HttpMethod.Delete // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                return new ActionResponse<Egg> { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
    }

}