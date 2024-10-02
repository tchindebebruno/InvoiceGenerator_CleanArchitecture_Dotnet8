using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator_CleanArchitecture_Dotnet8.Infrastructure
{
    public class ImageSaver : IImageSaver
    {
        public void SaveImage(SKBitmap bitmap, string filePath)
        {
            using (var image = SKImage.FromBitmap(bitmap))
            using (var stream = File.OpenWrite(filePath))
            {
                image.Encode(SKEncodedImageFormat.Png, 100).SaveTo(stream);
            }
        }
    }

}
