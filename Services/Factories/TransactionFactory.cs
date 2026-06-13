using sipetok_form.Services.Products;

namespace sipetok_form.Services.Factories
{
    internal class TransactionFactory : ModuleFactory
    {
        public override IMethod CreateMethod(string actionType)
        {
            switch (actionType.ToLower())
            {
                case "get":
                case "show":
                case "read":
                    return new GetData(HttpClient);

                // Tambahkan ini untuk handle Create & Update
                case "create":
                case "pay":
                case "complete":
                case "cancel":
                    return new SaveData(HttpClient);

                default:
                    throw new ArgumentException($"Aksi '{actionType}' tidak dikenali di TransactionFactory.");
            }
        }
    }
}