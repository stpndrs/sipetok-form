using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Helpers.Export
{
    /// <summary>
    /// Interface cetak biru untuk semua mesin pengekspor laporan (Excel, PDF, dll).
    /// </summary>
    internal interface IReportExporter
    {
        /// <summary>
        /// Mengekspor daftar data operasional menjadi berkas fisik di direktori tertentu.
        /// </summary>
        void ExportOperationalList(List<Operational> operationalList, string filePath);

        /// <summary>
        /// Mengekspor daftar data transaksi menjadi berkas fisik di direktori tertentu.
        /// </summary>
        void ExportTransactionList(List<Transaction> transactionList, string filePath);
    }
}
