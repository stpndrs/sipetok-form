namespace sipetok_form.Helpers.Export
{
    /// <summary>
    /// Class abstrak (pabrik utama) berbasis Factory Method Pattern untuk membuat objek pembuat laporan.
    /// </summary>
    internal abstract class ReportExporterFactory
    {
        /// <summary>
        /// Method pabrik abstrak yang harus diimplementasikan oleh setiap jenis dokumen tujuan.
        /// </summary>
        public abstract IReportExporter CreateExporter();
    }

    /// <summary>
    /// Pabrik khusus untuk memproduksi komponen pengekspor dokumen Microsoft Excel.
    /// </summary>
    internal class ExcelReportExporterFactory : ReportExporterFactory
    {
        /// <summary>
        /// Membuat dan mengembalikan instance pembuat laporan berformat Excel.
        /// </summary>
        public override IReportExporter CreateExporter() => new ExcelReportExporter();
    }

    /// <summary>
    /// Pabrik khusus untuk memproduksi komponen pengekspor dokumen Adobe PDF.
    /// </summary>
    internal class PdfReportExporterFactory : ReportExporterFactory
    {
        /// <summary>
        /// Membuat dan mengembalikan instance pembuat laporan berformat PDF.
        /// </summary>
        public override IReportExporter CreateExporter() => new PdfReportExporter();
    }
}
