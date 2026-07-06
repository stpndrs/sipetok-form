using sipetok_form.Dto.request;
using sipetok_form.Dto.response;
using sipetok_form.Models;
using sipetok_form.Services.Factories;
using sipetok_form.Services.Products;
using System.Diagnostics;

namespace sipetok_form.Services
{
    internal class EggCategoryApiService
    {
        private readonly ModuleFactory _eggCategoryFactory;
        private const string BaseEndpoint = "egg/categories";

        public EggCategoryApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _eggCategoryFactory = new EggCategoryFactory();
        }

        public async Task<List<EggCategory>?> GetEggCategoriesAsync()
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _eggCategoryFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                //penerapan teknik DRY 
                var response = await getService.ActionAsync<ApiResponse<EggCategory>>(BaseEndpoint);

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ActionResponse<EggCategory>> CreateEggCategoryAsync(EggCategory eggCategory)
        {
            try
            {
                // Minta produk "save" ke factory
                IMethod saveService = _eggCategoryFactory.CreateMethod("save");

                // Bungkus body request-nya
                var requestBody = new EggCategorySaveRequest
                {
                    Name = eggCategory.Name,
                    Description = eggCategory.Description,
                    Price = eggCategory.Price,
                    TenantId = eggCategory.TenantId
                };

                // Panggil ActionAsync ke-2: passing <EggCategorySaveRequest, ActionResponse<EggCategory>>
                var result = await saveService.ActionAsync<EggCategorySaveRequest, ActionResponse<EggCategory>>(
                    "egg/categories",
                    requestBody,
                    HttpMethod.Post // Tentukan methodnya POST
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<EggCategory> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<EggCategory>> UpdateEggCategoryAsync(int id, EggCategory eggCategory)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _eggCategoryFactory.CreateMethod("save");

                var requestBody = new EggCategorySaveRequest
                {
                    Name = eggCategory.Name,
                    Description = eggCategory.Description,
                    Price = eggCategory.Price,
                    TenantId = eggCategory.TenantId
                };

                // Panggil ActionAsync ke-2: arahkan ke endpoint "egg/categories/{id}" dengan method PUT
                var result = await saveService.ActionAsync<EggCategorySaveRequest, ActionResponse<EggCategory>>(
                    $"egg/categories/{id}",
                    requestBody,
                    HttpMethod.Put // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<EggCategory> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<EggCategory>> DeleteEggCategoryAsync(int id)
        {
            try
            {
                // Minta produk "save" yang sama karena sama-sama mengirim payload data
                IMethod deleteService = _eggCategoryFactory.CreateMethod("delete");
                var result = await deleteService.ActionAsync<EggCategorySaveRequest, ActionResponse<EggCategory>>(
                    $"egg/categories/{id}",
                    null,
                    HttpMethod.Delete // Tentukan methodnya PUT
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<EggCategory> { Success = false, Message = $"Gagal terhubung ke server: {ex.Message}" };
            }
        }
    }

}