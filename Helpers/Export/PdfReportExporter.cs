using iTextSharp.text;
using iTextSharp.text.pdf;
using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using iTextFont = iTextSharp.text.Font;

namespace sipetok_form.Helpers.Export
{
    /// <summary>
    /// Komponen mesin pengekspor (Concrete Exporter) yang bertanggung jawab menghasilkan dokumen Adobe PDF (.pdf) menggunakan iTextSharp.
    /// </summary>
    internal class PdfReportExporter : IReportExporter
    {
        private readonly iTextFont _titleFont = FontFactory.GetFont("Arial", 16, iTextFont.BOLD, BaseColor.BLACK);
        private readonly iTextFont _headerFont = FontFactory.GetFont("Arial", 9, iTextFont.BOLD, BaseColor.WHITE);
        private readonly iTextFont _dataFont = FontFactory.GetFont("Arial", 8, iTextFont.NORMAL, BaseColor.BLACK);
        private readonly iTextFont _subDataFont = FontFactory.GetFont("Arial", 8, iTextFont.ITALIC, BaseColor.DARK_GRAY);

        private const string NumericFormat = "#,##0";
        private const string DateFormatShort = "yyyy-MM-dd";
        private const string DateFormatFull = "yyyy-MM-dd HH:mm";
        private static readonly BaseColor ThemeGreenColor = new BaseColor(46, 125, 50);

        /// <summary>
        /// Mengekspor daftar pengeluaran operasional ke dalam berkas PDF dengan orientasi Portrait (A4).
        /// </summary>
        public void ExportOperationalList(List<Operational> operationalList, string filePath)
        {
            using (var document = new Document(PageSize.A4, 20f, 20f, 20f, 20f))
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(document, fileStream);
                document.Open();

                AddReportTitle(document, "LAPORAN OPERASIONAL");

                // Setup Tabel (4 Kolom)
                var table = new PdfPTable(4) { WidthPercentage = 100 };
                table.SetWidths(new float[] { 1f, 4f, 3f, 3f });

                string[] headers = { "ID", "Nama Pengeluaran", "Biaya (Cost)", "Tanggal" };
                AddTableHeaders(table, headers);

                // Isi Konten Data
                foreach (var item in operationalList)
                {
                    table.AddCell(CreateCenterCell(item.Id.ToString(), _dataFont));
                    table.AddCell(CreateLeftCell(item.Name, _dataFont));
                    table.AddCell(CreateRightCell($"{item.OperationalCost:#,##0}", _dataFont));
                    table.AddCell(CreateCenterCell(item.OperationalDate.ToString(DateFormatShort), _dataFont));
                }

                document.Add(table);
                document.Close();
            }
        }

        /// <summary>
        /// Mengekspor daftar transaksi beserta item detailnya ke dalam berkas PDF dengan orientasi Landscape (A4 Rotated).
        /// </summary>
        public void ExportTransactionList(List<Transaction> transactionList, string filePath)
        {
            using (var document = new Document(PageSize.A4.Rotate(), 15f, 15f, 20f, 20f))
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(document, fileStream);
                document.Open();

                AddReportTitle(document, "LAPORAN DATA TRANSAKSI");

                // Setup Tabel (11 Kolom)
                var table = new PdfPTable(11) { WidthPercentage = 100 };
                table.SetWidths(new float[] { 0.8f, 1.8f, 1.8f, 1.3f, 1.2f, 1.5f, 1.2f, 1.5f, 0.8f, 1f, 1.3f });

                string[] headers = {
                    "ID TX", "Tanggal", "Pelanggan", "Status Bayar",
                    "Status Order", "Total Belanja", "Kategori", "Harga Satuan",
                    "Qty", "Subtotal", "No. HP"
                };
                AddTableHeaders(table, headers);

                // Isi Konten Data Master-Detail
                foreach (var transaction in transactionList)
                {
                    int detailCount = transaction.Details?.Count ?? 0;

                    if (detailCount == 0)
                    {
                        AddMasterCells(table, transaction, _dataFont);
                        AddEmptyDetailCells(table);
                        table.AddCell(CreateLeftCell(transaction.CustomerPhoneNumber, _dataFont));
                    }
                    else
                    {
                        bool isFirstRow = true;
                        foreach (var detail in transaction.Details)
                        {
                            iTextFont activeFont = isFirstRow ? _dataFont : _subDataFont;

                            AddMasterCells(table, transaction, activeFont);
                            WriteTransactionDetailCells(table, detail);
                            table.AddCell(CreateLeftCell(transaction.CustomerPhoneNumber, activeFont));

                            isFirstRow = false;
                        }
                    }
                }

                document.Add(table);
                document.Close();
            }
        }

        #region Helper Core Logic Methods (KISS & DRY)

        /// <summary>
        /// Menambahkan judul dokumen utama di bagian atas halaman PDF.
        /// </summary>
        private void AddReportTitle(Document document, string titleText)
        {
            var titleParagraph = new Paragraph($"{titleText}\n\n", _titleFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(titleParagraph);
        }

        /// <summary>
        /// Membuat baris header tabel dengan latar belakang warna tema hijau secara dinamis.
        /// </summary>
        private void AddTableHeaders(PdfPTable table, string[] headers)
        {
            foreach (var headerText in headers)
            {
                var cell = new PdfPCell(new Phrase(headerText, _headerFont))
                {
                    BackgroundColor = ThemeGreenColor,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    Padding = 6
                };
                table.AddCell(cell);
            }
        }

        /// <summary>
        /// Memasukkan data segmen master dari objek transaksi ke dalam sel tabel PDF.
        /// </summary>
        private static void AddMasterCells(PdfPTable table, Transaction transaction, iTextFont targetFont)
        {
            table.AddCell(CreateCenterCell(transaction.Id.ToString(), targetFont));
            table.AddCell(CreateLeftCell(transaction.Date.ToString(DateFormatFull), targetFont));
            table.AddCell(CreateLeftCell(transaction.CustomerName, targetFont));
            table.AddCell(CreateCenterCell(transaction.PaymentStatus, targetFont));
            table.AddCell(CreateCenterCell(transaction.OrderStatus, targetFont));
            table.AddCell(CreateRightCell(transaction.TotalPrice.ToString(NumericFormat), targetFont));
        }

        /// <summary>
        /// Menulis data spesifik detail item belanja transaksi ke dalam sel tabel PDF.
        /// </summary>
        private void WriteTransactionDetailCells(PdfPTable table, TransactionDetail detail)
        {
            table.AddCell(CreateLeftCell(detail.Category?.Name ?? "-", _dataFont));
            table.AddCell(CreateRightCell(detail.PriceAtPurchase.ToString(NumericFormat), _dataFont));
            table.AddCell(CreateCenterCell(detail.Quantity.ToString(), _dataFont));
            table.AddCell(CreateRightCell(detail.Subtotal.ToString(NumericFormat), _dataFont));
        }

        /// <summary>
        /// Mengisi slot kolom komponen detail dengan tanda strip (-) jika transaksi tidak memiliki detail belanja.
        /// </summary>
        private void AddEmptyDetailCells(PdfPTable table)
        {
            for (int i = 0; i < 4; i++)
            {
                table.AddCell(CreateCenterCell("-", _dataFont));
            }
        }

        #region Cell Factory Helpers (Mengurangi Boilerplate Code)

        private static PdfPCell CreateLeftCell(string text, iTextFont font) =>
            new PdfPCell(new Phrase(text, font)) { Padding = 4, VerticalAlignment = Element.ALIGN_MIDDLE };

        private static PdfPCell CreateCenterCell(string text, iTextFont font) =>
            new PdfPCell(new Phrase(text, font)) { Padding = 4, HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };

        private static PdfPCell CreateRightCell(string text, iTextFont font) =>
            new PdfPCell(new Phrase(text, font)) { Padding = 4, HorizontalAlignment = Element.ALIGN_RIGHT, VerticalAlignment = Element.ALIGN_MIDDLE };

        #endregion

        #endregion
    }
}