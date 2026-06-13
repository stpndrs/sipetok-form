using iTextSharp.text;
using iTextSharp.text.pdf;
using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.IO;

using iTextFont = iTextSharp.text.Font;

namespace sipetok_form.Helpers.Export
{
    internal class PdfExporter : IExport
    {
        // Pengaturan Font Standar Dokumen
        private readonly iTextFont titleFont = FontFactory.GetFont("Arial", 16, iTextFont.BOLD, BaseColor.BLACK);
        private readonly iTextFont headerFont = FontFactory.GetFont("Arial", 9, iTextFont.BOLD, BaseColor.WHITE);
        private readonly iTextFont dataFont = FontFactory.GetFont("Arial", 8, iTextFont.NORMAL, BaseColor.BLACK);
        private readonly iTextFont subDataFont = FontFactory.GetFont("Arial", 8, iTextFont.ITALIC, BaseColor.DARK_GRAY);

        public void ExportOperationalList(List<Operational> operationalList, string filePath)
        {
            // 1. Inisialisasi Dokumen PDF (Ukuran A4, Portrait)
            Document document = new Document(PageSize.A4, 20f, 20f, 20f, 20f);

            try
            {
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Judul Laporan
                Paragraph title = new Paragraph("LAPORAN OPERASIONAL\n\n", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // 2. Membuat Tabel dengan 4 Kolom
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100; // Lebar tabel memenuhi halaman
                table.SetWidths(new float[] { 1f, 4f, 3f, 3f }); // Proporsi lebar kolom

                // Header Tabel
                string[] headers = { "ID", "Nama Pengeluaran", "Biaya (Cost)", "Tanggal" };
                foreach (var headerText in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(headerText, headerFont));
                    cell.BackgroundColor = new BaseColor(46, 125, 50); // Hijau Formal
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 6;
                    table.AddCell(cell);
                }

                // Isi Data Operasional
                foreach (var item in operationalList)
                {
                    table.AddCell(new PdfPCell(new Phrase(item.Id.ToString(), dataFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 });
                    table.AddCell(new PdfPCell(new Phrase(item.Name, dataFont)) { Padding = 5 });

                    // Format Angka Currency
                    string costStr = $"{item.OperationalCost:#,##0}";
                    table.AddCell(new PdfPCell(new Phrase(costStr, dataFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });

                    // Format Tanggal
                    string dateStr = item.OperationalDate.ToString("yyyy-MM-dd");
                    table.AddCell(new PdfPCell(new Phrase(dateStr, dataFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 });
                }

                document.Add(table);
            }
            finally
            {
                document.Close();
            }
        }

        public void ExportTransactionList(List<Transaction> transactionList, string filePath)
        {
            // Karena kolom transaksi sangat banyak (11 kolom), disarankan memakai Landscape agar muat dan tidak terpotong
            Document document = new Document(PageSize.A4.Rotate(), 15f, 15f, 20f, 20f);

            try
            {
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Judul Laporan
                Paragraph title = new Paragraph("LAPORAN DATA TRANSAKSI\n\n", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Pembuatan Tabel (11 Kolom utama yang esensial)
                PdfPTable table = new PdfPTable(11);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 0.8f, 1.8f, 1.8f, 1.3f, 1.2f, 1.5f, 1.2f, 1.5f, 0.8f, 1f, 1.3f });

                // Header Kolom PDF
                string[] headers = {
                    "ID TX", "Tanggal", "Pelanggan", "Status Bayar",
                    "Status Order", "Total Belanja", "Kategori", "Harga Satuan",
                    "Qty", "Subtotal", "No. HP"
                };

                foreach (var headerText in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(headerText, headerFont));
                    cell.BackgroundColor = new BaseColor(46, 125, 50); // Hijau Formal
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.Padding = 6;
                    table.AddCell(cell);
                }

                // Isi Data Transaksi berkelompok dengan Detailnya (RowSpan Simulation)
                foreach (var tx in transactionList)
                {
                    int detailCount = tx.Details?.Count ?? 0;

                    if (detailCount == 0)
                    {
                        // Jika transaksi kosong / tidak ada detail
                        AddMasterCells(table, tx, dataFont);

                        // Isi kolom detail kosong dengan tanda strip
                        for (int i = 0; i < 4; i++)
                            table.AddCell(new PdfPCell(new Phrase("-", dataFont)) { HorizontalAlignment = Element.ALIGN_CENTER });

                        table.AddCell(new PdfPCell(new Phrase(tx.CustomerPhoneNumber, dataFont)));
                    }
                    else
                    {
                        bool isFirstRow = true;
                        foreach (var detail in tx.Details)
                        {
                            // Konsep row grouping: Data master diulang per baris detail agar strukturnya sejajar rapi
                            AddMasterCells(table, tx, isFirstRow ? dataFont : subDataFont);

                            // Data Spesifik Detail Item
                            table.AddCell(new PdfPCell(new Phrase(detail.Category?.Name ?? "-", dataFont)) { Padding = 4 });
                            table.AddCell(new PdfPCell(new Phrase(detail.PriceAtPurchase.ToString("#,##0"), dataFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 4 });
                            table.AddCell(new PdfPCell(new Phrase(detail.Quantity.ToString(), dataFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 });
                            table.AddCell(new PdfPCell(new Phrase(detail.Subtotal.ToString("#,##0"), dataFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 4 });

                            // No HP Pelanggan di kolom paling kanan
                            table.AddCell(new PdfPCell(new Phrase(tx.CustomerPhoneNumber, isFirstRow ? dataFont : subDataFont)) { Padding = 4 });

                            isFirstRow = false; // Baris detail berikutnya akan menggunakan font abu-abu tipis (subDataFont)
                        }
                    }
                }

                document.Add(table);
            }
            finally
            {
                document.Close();
            }
        }

        // Helper Method untuk mengisi bagian data master transaksi ke dalam baris tabel PDF
        private void AddMasterCells(PdfPTable table, Transaction tx, iTextFont fontTarget)
        {
            table.AddCell(new PdfPCell(new Phrase(tx.Id.ToString(), fontTarget)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 });
            table.AddCell(new PdfPCell(new Phrase(tx.Date.ToString("yyyy-MM-dd HH:mm"), fontTarget)) { Padding = 4 });
            table.AddCell(new PdfPCell(new Phrase(tx.CustomerName, fontTarget)) { Padding = 4 });
            table.AddCell(new PdfPCell(new Phrase(tx.PaymentStatus, fontTarget)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 });
            table.AddCell(new PdfPCell(new Phrase(tx.OrderStatus, fontTarget)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 });
            table.AddCell(new PdfPCell(new Phrase($"{tx.TotalPrice:#,##0}", fontTarget)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 4 });
        }
    }
}