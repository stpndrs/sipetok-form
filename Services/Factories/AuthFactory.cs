using sipetok_form.Services.Products;

namespace sipetok_form.Services.Factories
{
    internal class AuthFactory : ModuleFactory
    {
        public override IMethod CreateMethod(string actionType)
        {
            switch (actionType.ToLower())
            {
                case "save":
                case "write":
                    return new SaveData(HttpClient);

                default:
                    throw new ArgumentException($"Aksi '{actionType}' tidak dikenali di UserFactory.");
            }
        }
    }
}