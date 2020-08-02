using System.Collections.Generic;
using System.IO;

namespace BasketballTimer.Services
{
    class ImageService
    {
        public List<string> Images { get; set; }

        public ImageService()
        {
            Images = new List<string>();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            path = Directory.GetParent(path).FullName;

            Images.Add(path + @"\Images\Celtics.png");
            Images.Add(path + @"\Images\ChicagoBulls.png");
            Images.Add(path + @"\Images\Heat.png");
            Images.Add(path + @"\Images\Knicks.png");
            Images.Add(path + @"\Images\Lakers.png");
            Images.Add(path + @"\Images\Pistons.png");
            Images.Add(path + @"\Images\Spurs.png");
            Images.Add(path + @"\Images\Warriors.png");
        }
    }
}
