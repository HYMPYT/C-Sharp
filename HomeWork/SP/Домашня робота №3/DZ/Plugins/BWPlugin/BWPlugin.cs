using System;
using System.Drawing;

namespace BWPlugin
{
    public class BWPlugin : Interface.IPlugin
    {
        public string Name
        {
            get { return "Черно белое изображение"; }
        }

        public string Version
        {
            get { return "1.0"; }
        }

        public string Author
        {
            get { return "Proger"; }
        }

        public void Transform(Interface.IMainApp app)
        {
            Bitmap bitmap = app.Image;
            Random rand = new Random(DateTime.Now.Millisecond);
            Color colorValue;
            int averageValue;

            for (int row = 0; row < bitmap.Width; row++)
            {
                for (int column = 0; column < bitmap.Height; column++)
                {
                    colorValue = bitmap.GetPixel(row, column);
                    averageValue = ((int)colorValue.R + (int)colorValue.B + (int)colorValue.G) / 3;
                    bitmap.SetPixel(row, column, Color.FromArgb(averageValue, averageValue, averageValue));
                }
            }

            app.Image = bitmap;
        }
    }
}
