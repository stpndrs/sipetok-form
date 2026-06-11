using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Services.Products
{
    internal interface IMethod
    {
        // untuk terima data
        Task<TResponse> ActionAsync<TResponse>(string endpoint);

        // untuk kirim data
        Task<TResponse> ActionAsync<TRequest, TResponse>(string endpoint, TRequest data, HttpMethod method);
    }
}
