using SkiaSharp;

namespace SkiaSharpSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var skImage = SKImage.FromEncodedData(Resource.Sample);
            using SKData data = skImage.Encode(SKEncodedImageFormat.Png, 100);
            File.WriteAllBytes("result.png", data.ToArray());
        }
    }
}
