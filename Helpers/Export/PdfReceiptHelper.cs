using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using sipetok_form.Models;
using System;
using System.IO;
using iTextFont = iTextSharp.text.Font;

namespace sipetok_form.Helpers.Export
{
    internal class PdfReceiptHelper
    {
        // Menggunakan font standar dengan ukuran yang disesuaikan untuk struk kecil
        private static readonly iTextFont FontStoreTitle = FontFactory.GetFont("Courier", 12, iTextFont.BOLD, BaseColor.BLACK);
        private static readonly iTextFont FontHeader = FontFactory.GetFont("Courier", 9, iTextFont.BOLD, BaseColor.BLACK);
        private static readonly iTextFont FontRegular = FontFactory.GetFont("Courier", 9, iTextFont.NORMAL, BaseColor.BLACK);
        private static readonly iTextFont FontFooter = FontFactory.GetFont("Courier", 8, iTextFont.ITALIC, BaseColor.DARK_GRAY);

        private const string NumericFormat = "#,##0";

        /// <summary>
        /// Membuat berkas PDF struk belanja dalam format kertas kasir (Lebar 80mm, Tinggi dinamis otomatis)
        /// </summary>
        public static void GenerateReceipt(Transaction transaction, string filePath)
        {
            // Ukuran kertas Thermal Kasir 80mm standar (sekitar 226 x 500 poin)
            var receiptSize = new iTextSharp.text.Rectangle(226f, 600f);

            using (var document = new Document(receiptSize, 10f, 10f, 10f, 10f))
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                PdfWriter.GetInstance(document, fileStream);
                document.Open();

                // 1. HEADER TOKO
                var storeTitle = new Paragraph("SIPETOK EGG STORE\n", FontStoreTitle) { Alignment = Element.ALIGN_CENTER };
                var storeAddress = new Paragraph("Jl. Raya Telur No. 123, Surabaya\nTelp: 0812-3456-7890\n", FontFooter) { Alignment = Element.ALIGN_CENTER };
                document.Add(storeTitle);
                document.Add(storeAddress);

                // Garis Pembatas Putus-Putus
                document.Add(CreateDottedLine());

                // 2. METADATA TRANSAKSI (ID, Tanggal, Pelanggan)
                var metaTable = new PdfPTable(2) { WidthPercentage = 100 };
                metaTable.SetWidths(new float[] { 4f, 6f });

                AddMetaRow(metaTable, "Nota ID", $": #{transaction.Id}");
                AddMetaRow(metaTable, "Tanggal", $": {transaction.Date:yyyy-MM-dd HH:mm}");
                AddMetaRow(metaTable, "Kasir", $": Tenant {transaction.TenantId}");
                AddMetaRow(metaTable, "Pelanggan", $": {transaction.CustomerName}");
                AddMetaRow(metaTable, "Status", $": {transaction.PaymentStatus}");

                document.Add(metaTable);
                document.Add(CreateDottedLine());

                // 3. DAFTAR ITEM BELANJA
                var itemTable = new PdfPTable(3) { WidthPercentage = 100 };
                itemTable.SetWidths(new float[] { 5f, 2f, 3f }); // Item, Qty, Subtotal

                // Header Item
                itemTable.AddCell(CreateReceiptCell("Item/Kategori", FontHeader, Element.ALIGN_LEFT));
                itemTable.AddCell(CreateReceiptCell("Qty", FontHeader, Element.ALIGN_CENTER));
                itemTable.AddCell(CreateReceiptCell("Total", FontHeader, Element.ALIGN_RIGHT));

                foreach (var detail in transaction.Details)
                {
                    string categoryName = detail.Category?.Name ?? $"Kategori {detail.CategoryId}";

                    // Baris 1: Nama Item
                    itemTable.AddCell(CreateReceiptCell(categoryName, FontRegular, Element.ALIGN_LEFT));
                    // Baris 2: Qty (misal: 2)
                    itemTable.AddCell(CreateReceiptCell(detail.Quantity.ToString("0.#"), FontRegular, Element.ALIGN_CENTER));
                    // Baris 3: Subtotal (misal: 50,000)
                    itemTable.AddCell(CreateReceiptCell(detail.Subtotal.ToString(NumericFormat), FontRegular, Element.ALIGN_RIGHT));

                    // Info Tambahan: Harga Satuan di bawah nama item (opsional, estetik struk)
                    itemTable.AddCell(CreateReceiptCell($" @{detail.PriceAtPurchase.ToString(NumericFormat)}", FontFooter, Element.ALIGN_LEFT));
                    itemTable.AddCell(CreateReceiptCell("", FontRegular, Element.ALIGN_CENTER));
                    itemTable.AddCell(CreateReceiptCell("", FontRegular, Element.ALIGN_RIGHT));
                }

                document.Add(itemTable);
                document.Add(CreateDottedLine());

                // 4. TOTAL & PEMBAYARAN
                var calcTable = new PdfPTable(2) { WidthPercentage = 100 };
                calcTable.SetWidths(new float[] { 6f, 4f });

                AddMetaRow(calcTable, "TOTAL BELANJA :", transaction.TotalPrice.ToString(NumericFormat), FontHeader, Element.ALIGN_RIGHT);
                AddMetaRow(calcTable, "TUNAI/BAYAR   :", transaction.PaymentAmount.ToString(NumericFormat), FontRegular, Element.ALIGN_RIGHT);

                decimal kembalian = transaction.PaymentAmount - transaction.TotalPrice;
                if (kembalian < 0) kembalian = 0; // Proteksi nilai minus

                AddMetaRow(calcTable, "KEMBALIAN     :", kembalian.ToString(NumericFormat), FontRegular, Element.ALIGN_RIGHT);

                document.Add(calcTable);
                document.Add(CreateDottedLine());

                // 5. FOOTER / TERIMA KASIH
                var thankYou = new Paragraph("\n~~ Terima Kasih ~~\nSelamat Menikmati Telur Segar Anda\n", FontFooter)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                document.Add(thankYou);

                document.Close();
            }
        }

        #region Helper Renderers

        private static Paragraph CreateDottedLine()
        {
            var line = new DottedLineSeparator { Percentage = 100f, Alignment = Element.ALIGN_CENTER };
            var p = new Paragraph { line };
            p.SpacingBefore = 4f;
            p.SpacingAfter = 4f;
            return p;
        }

        private static void AddMetaRow(PdfPTable table, string label, string val)
        {
            table.AddCell(CreateReceiptCell(label, FontRegular, Element.ALIGN_LEFT));
            table.AddCell(CreateReceiptCell(val, FontRegular, Element.ALIGN_LEFT));
        }

        private static void AddMetaRow(PdfPTable table, string label, string val, iTextFont font, int alignment)
        {
            table.AddCell(CreateReceiptCell(label, font, alignment));
            table.AddCell(CreateReceiptCell(val, font, Element.ALIGN_RIGHT));
        }

        private static PdfPCell CreateReceiptCell(string text, iTextFont font, int alignment)
        {
            return new PdfPCell(new Phrase(text, font))
            {
                Border = iTextSharp.text.Rectangle.NO_BORDER,// Struk kasir umumnya bebas border kotak/grid
                HorizontalAlignment = alignment,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 2f
            };
        }

        #endregion
    }
}