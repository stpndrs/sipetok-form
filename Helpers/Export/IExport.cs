using sipetok_form.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sipetok_form.Helpers.Export
{
    internal interface IExport
    {
        void ExportOperationalList(List<Operational> operationalList, string filePath);
        void ExportTransactionList(List<Transaction> transactionList, string filePath);
    }
}
