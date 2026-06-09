using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Helpers.Export
{
    internal interface IExport
    {
        static abstract void ExportOperationalList(List<Operational> operationalList, string filePath);
        static abstract void ExportTransactionList(List<Transaction> transactionList, string filePath);
    }
}
