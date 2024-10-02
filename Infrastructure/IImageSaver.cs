using SkiaSharp;

namespace InvoiceGenerator_CleanArchitecture_Dotnet8.Infrastructure
{
    public interface IImageSaver
    {
        void SaveImage(SKBitmap bitmap, string filePath);
    }

}
