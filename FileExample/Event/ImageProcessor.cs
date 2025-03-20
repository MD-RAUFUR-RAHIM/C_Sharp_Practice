using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class ImageProcessor
    {
        public delegate void ImageProcessingEndTrigger();
        public event ImageProcessingEndTrigger ProcessEnd;
        public void ProcessImageSize()
        {
            ProcessEnd?.Invoke();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Muhammad IS  A GOOD boy {i}");
            }
            

        }
    }
}
