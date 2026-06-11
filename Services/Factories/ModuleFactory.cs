using sipetok_form.Services.Products;

namespace sipetok_form.Services.Factories
{
    internal abstract class ModuleFactory
    {
        protected readonly HttpClient HttpClient;

        protected ModuleFactory()
        {
            HttpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5062/api/") };
        }

        // Factory Method utamanya
        public abstract IMethod CreateMethod(string actionType);
    }
}