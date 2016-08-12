using Android.App;
using Android.Views;
using Android.Widget;
using RaysTest.Core.Model;
using RayTest.Droid.Utility;
using System.Collections.Generic;

namespace RayTest.Droid.Adapters
{
    public class HotDogListAdapter : BaseAdapter<HotDog>
    {
        private List<HotDog> _items;
        private Activity _context;

        public HotDogListAdapter(Activity context , List<HotDog> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override HotDog this[int position]
        {
            get
            {
                return this._items[position];
            }
        }

        public override int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return _items[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            var image = ImageHelper.GetImageBitmapFromUrl("http://rustlersonline.com/wp-content/uploads/" + item.ImagePath + ".png");
            int listResource = Resource.Layout.HotDogRowView;
            int imageResource = Resource.Id.hotDogImageView;

            if (convertView == null)
            {
                convertView = _context.LayoutInflater.Inflate(listResource, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.hotDogNameTextView).Text = item.Name;
            convertView.FindViewById<TextView>(Resource.Id.hotDogLabelTextView).Text = item.ShortDescription;
            convertView.FindViewById<TextView>(Resource.Id.priceTextView).Text = "$" + item.Price;
            convertView.FindViewById<ImageView>(imageResource).SetImageBitmap(image);

            return convertView;
        }
    }
}