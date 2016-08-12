using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using System.Net;

namespace RayTest.Droid.Utility
{
    public class ImageHelper
    {
        private static IDictionary<string, Bitmap> _cache = new Dictionary<string, Bitmap>();

        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            if (!_cache.ContainsKey(url))
            {
                Bitmap imageBitmap = null;
                using (var webClient = new WebClient())
                {
                    var bytes = webClient.DownloadData(url);
                    if (bytes != null && bytes.Length > 0)
                    {
                        imageBitmap = BitmapFactory.DecodeByteArray(bytes, 0, bytes.Length);
                    }
                    _cache.Add(url, imageBitmap);
                    return imageBitmap;
                }
            } else
            {
                return _cache[url];
            }
        }
    }
}