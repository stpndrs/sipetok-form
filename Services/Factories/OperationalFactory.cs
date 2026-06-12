using sipetok_form.Services.Products;

namespace sipetok_form.Services.Factories
{
    internal class OperationalFactory : ModuleFactory
    {
        public override IMethod CreateMethod(string actionType)
        {
            switch (actionType.ToLower())
            {
                case "get":
                case "read":
                    return new GetData(HttpClient);

                // Tambahkan ini untuk handle Create & Update
                case "save":
                case "write":
                    return new SaveData(HttpClient);

                case "delete":
                    return new DeleteData(HttpClient);

                default:
                    throw new ArgumentException($"Aksi '{actionType}' tidak dikenali di OperationalFactory.");
            }
        }
    }
}