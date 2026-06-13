namespace sipetok_form.Helpers.Export
{
    internal abstract class ExportFactory
    {
        public abstract IExport CreateExporter();
    }

    internal class ExcelFactory : ExportFactory
    {
        public override IExport CreateExporter() => new ExcelExporter();
    }

    internal class PdfFactory : ExportFactory
    {
        public override IExport CreateExporter() => new PdfExporter();
    }
}
