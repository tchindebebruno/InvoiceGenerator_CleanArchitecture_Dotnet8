using InvoiceGenerator_CleanArchitecture_Dotnet8.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator_CleanArchitecture_Dotnet8.Presentation
{
    public class InvoicePresenter
    {
        private readonly IInvoiceService _invoiceService;

        public InvoicePresenter(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public void CreateInvoice(string logoPath)
        {
            _invoiceService.GenerateInvoice(logoPath);
            Console.WriteLine("Facture créée avec succès !");
        }
    }

}
