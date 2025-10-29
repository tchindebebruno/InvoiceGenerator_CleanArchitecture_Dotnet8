using SkiaSharp;

namespace Image_Generator.Application
{
    public interface IImageSaver
    {
        void SaveImage(SKBitmap bitmap, string filePath);
    }

}
