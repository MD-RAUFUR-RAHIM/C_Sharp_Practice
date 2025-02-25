// See https://aka.ms/new-console-template for more information
using Event;

Console.WriteLine("Hello, World!");
ImageProcessor imageProcessor = new ImageProcessor();
imageProcessor.ProcessEnd += ImageProcessor_ProcessEnd;
imageProcessor.ProcessEnd += ImageProcessor_ProcessEnd2;
imageProcessor.ProcessImageSize();
void ImageProcessor_ProcessEnd()
{
    Console.WriteLine("<<<<<<<<<<All Image Processed>>>>>>>>>>>>");
}
void ImageProcessor_ProcessEnd2()
{
    Console.WriteLine("~~~~~~~~ All Image Processed ~~~~~~~~~~~");
}