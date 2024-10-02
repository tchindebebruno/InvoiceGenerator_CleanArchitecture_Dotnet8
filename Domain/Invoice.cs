namespace InvoiceGenerator_CleanArchitecture_Dotnet8.Domain
{
    public class Invoice
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<InvoiceAttribute>? Attributes { get; set; } 
    }
}
