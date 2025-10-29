using Image_Generator.Infrastructure;
using InvoiceGenerator_CleanArchitecture_Dotnet8.Infrastructure;
using InvoiceGenerator_CleanArchitecture_Dotnet8.Presentation;

string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png");

var imageSaver = new ImageSaver();
var invoiceService = new InvoiceService(imageSaver);
var presenter = new InvoicePresenter(invoiceService);

presenter.CreateInvoice(logoPath);
