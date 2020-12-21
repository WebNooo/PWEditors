using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Pfim;
using PixelFormat = System.Drawing.Imaging.PixelFormat;

namespace PWHelper
{
    public class Icons
    {
        private static int weightImage;
        private static int heightImage;

        private static int rows;
        private static int columns;

        private static int countIcon;

        private static IImage imageSrc;
        private static Bitmap imageBitmap;

        private static GCHandle handle;

        private static List<string> iconsNames = new List<string>();

        public static void LoadIcons()
        {
            ReadImageNames();

            imageSrc = Pfim.Pfim.FromFile("resource/iconlist_ivtrm.dds");
            if (handle.IsAllocated) handle.Free();
            handle = GCHandle.Alloc(imageSrc.Data, GCHandleType.Pinned);
            imageBitmap = new Bitmap(imageSrc.Width, imageSrc.Height, imageSrc.Stride, ImageFormat(),
                Marshal.UnsafeAddrOfPinnedArrayElement(imageSrc.Data, 0));
        }

        private static void ReadImageNames()
        {
            using var sr = new StreamReader(new FileStream("resource/iconlist_ivtrm.txt", FileMode.Open),
                Encoding.GetEncoding("gb2312"));

            weightImage = Convert.ToInt32(sr.ReadLine());
            heightImage = Convert.ToInt32(sr.ReadLine());
            rows = Convert.ToInt32(sr.ReadLine());
            columns = Convert.ToInt32(sr.ReadLine());

            countIcon = rows * columns;

            string[] localNames = new string[countIcon];

            int index = 0;
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                localNames[index] = line.ToLower();
                index++;
            }

            iconsNames.AddRange(localNames);
            countIcon = index;
            sr.Close();
        }

        public static PixelFormat ImageFormat()
        {
            return imageSrc.Format switch
            {
                Pfim.ImageFormat.Rgb24 => PixelFormat.Format24bppRgb,
                Pfim.ImageFormat.Rgba32 => PixelFormat.Format32bppArgb,
                Pfim.ImageFormat.R5g5b5 => PixelFormat.Format16bppRgb555,
                Pfim.ImageFormat.R5g6b5 => PixelFormat.Format16bppRgb565,
                Pfim.ImageFormat.R5g5b5a1 => PixelFormat.Format16bppArgb1555,
                Pfim.ImageFormat.Rgb8 => PixelFormat.Format8bppIndexed,
                _ => 0
            };
        }

        private static object _locker = new object();

        public static ImageSource GetImage(int x, int y)
        {
            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            try
            {
                return BitmapToImageSource(imageBitmap.Clone(new Rectangle(x, y, weightImage, heightImage), PixelFormat.DontCare));
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static ImageSource GetImage(int index)
        {
            var y = (index / columns) * heightImage;
            int x;

            if (index < columns)
            {
                x = index * weightImage;
            }
            else
            {
                x = (index - (128 * (index / columns))) * heightImage;
            }

            return GetImage(x, y);
        }

        public static ImageSource GetImage(string name)
        {
            return GetImage(iconsNames.IndexOf(name));
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        public static ImageSource BitmapToImageSource(Bitmap bmp)
        {
            var bitmap = bmp.GetHbitmap();
            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(bitmap, IntPtr.Zero, Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(bitmap);
            }
        }
    }
}