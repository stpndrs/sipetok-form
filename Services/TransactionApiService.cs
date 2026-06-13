using sipetok_api.Models;
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
    internal class TransactionApiService
    {
        private readonly ModuleFactory _transactionFactory;

        public TransactionApiService()
        {
            // Daftarkan factory yang ingin dipakai
            _transactionFactory = new TransactionFactory();
        }

        public async Task<List<Transaction>?> GetTransactionsAsync()
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _transactionFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                var response = await getService.ActionAsync<dto.response.ApiResponse<Transaction>>("transactions");

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<Transaction> GetTransactionByIdAsync(int id)
        {
            try
            {
                // 1. Minta produk "get" ke factory
                IMethod getService = _transactionFactory.CreateMethod("get");

                // 2. Eksekusi action dengan passing target class response & endpoint-nya
                var response = await getService.ActionAsync<dto.response.SingleApiResponse<Transaction>>($"transactions/{id}");

                return response?.Data;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ActionResponse<Transaction>> CreateTransactionAsync(Transaction transaction)
        {
            try
            {
                // Minta produk "save" ke factory
                IMethod saveService = _transactionFactory.CreateMethod("create");

                // Bungkus body request-nya
                var requestBody = new TransactionSaveRequest
                {
                    Date = transaction.Date,
                    PaymentAmount = transaction.PaymentAmount,
                    CustomerName = transaction.CustomerName,
                    CustomerPhoneNumber = transaction.CustomerPhoneNumber,
                };

                if (transaction.Details != null)
                {
                    foreach (var item in transaction.Details)
                    {
                        requestBody.Details.Add(new TransactionDetailSaveRequest
                        {
                            CategoryId = item.CategoryId,
                            Quantity = item.Quantity,
                        });
                    }
                }

                // Panggil ActionAsync ke-2: passing <TransactionSaveRequest, ActionResponse<Transaction>>
                var result = await saveService.ActionAsync<TransactionSaveRequest, ActionResponse<Transaction>>(
                    "transactions",
                    requestBody,
                    HttpMethod.Post // Tentukan methodnya POST
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Transaction> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Transaction>> PayTransactionAsync(int id, Transaction transaction)
        {
            try
            {
                // Minta produk "pay" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _transactionFactory.CreateMethod("pay");

                var requestBody = new TransactionSaveRequest
                {
                    PaymentAmount = transaction.PaymentAmount,
                };

                // Panggil ActionAsync ke-2: arahkan ke endpoint "transactions/{id}" dengan method PUT
                var result = await saveService.ActionAsync<TransactionSaveRequest, ActionResponse<Transaction>>(
                    $"transactions/pay/{id}",
                    requestBody,
                    HttpMethod.Post // Tentukan methodnya Post
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Transaction> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Transaction>> CompleteTransactionAsync(int id)
        {
            try
            {
                // Minta produk "complete" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _transactionFactory.CreateMethod("complete");

                // Panggil ActionAsync ke-2: arahkan ke endpoint "transactions/{id}" dengan method PUT
                var result = await saveService.ActionAsync<TransactionSaveRequest, ActionResponse<Transaction>>(
                    $"transactions/complete/{id}",
                    null,
                    HttpMethod.Post // Tentukan methodnya Post
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Transaction> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ActionResponse<Transaction>> CancelTransactionAsync(int id)
        {
            try
            {
                // Minta produk "cancel" yang sama karena sama-sama mengirim payload data
                IMethod saveService = _transactionFactory.CreateMethod("cancel");

                // Panggil ActionAsync ke-2: arahkan ke endpoint "transactions/{id}" dengan method PUT
                var result = await saveService.ActionAsync<TransactionSaveRequest, ActionResponse<Transaction>>(
                    $"transactions/cancel/{id}",
                    null,
                    HttpMethod.Post // Tentukan methodnya Post
                );

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ActionResponse<Transaction> { Success = false, Message = ex.Message };
            }
        }
    }

}