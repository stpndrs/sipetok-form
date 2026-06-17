using sipetok_form.Services.Products;

namespace sipetok_form.Services.Factories
{
    internal class EggCategoryFactory : ModuleFactory
    {
        //penerapan clean code KISS dengan menggunakan switch expression untuk membuat kode lebih bersih dan mudah dibaca
        public override IMethod CreateMethod(string actionType)
        {
            return actionType.ToLower() switch
            {
                "get" or "read" => new GetData(HttpClient),
                "save" or "write" => new SaveData(HttpClient),
                "delete" => new DeleteData(HttpClient),
                _ => throw new ArgumentException($"Aksi '{actionType}' tidak dikenali di EggCategoryFactory.")
            };
        }
    }
}