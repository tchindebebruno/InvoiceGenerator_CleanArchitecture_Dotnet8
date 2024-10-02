namespace InvoiceGenerator_CleanArchitecture_Dotnet8.Application
{
    public interface IInvoiceService
    {
        void GenerateInvoice(string logoPath);
    }

}
