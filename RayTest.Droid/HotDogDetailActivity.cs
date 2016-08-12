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
using RaysTest.Core.Model;
using RaysTest.Core.Repository;
using RayTest.Droid.Utility;

namespace RayTest.Droid
{
    [Activity(Label = "Hot dog detail", MainLauncher = false)]
    public class HotDogDetailActivity : BaseCustomActivity
    {
        private ImageView _hotDogImageView;
        private TextView _hotDogNameTextView;
        private TextView _hotDogLabelDescriptionView;
        private TextView _hotDogDescriptionView;
        private TextView _hotDogPriceTextView;
        private EditText _amountEditText;
        private Button _cancelButton;
        private Button _orderButton;

        private HotDog _selectedHotDog;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.HotDogDetailView);

            int paramId = base.ActivityHelper.GetValueFromExtras<int>("Id");

            _selectedHotDog = base.ActivityHelper.FindSelectedHotDog(paramId);

            InitComponents();

            if (_selectedHotDog != null)
            {
                BindData();
            }

            BindEvents();
        }

        private void BindEvents()
        {
            this._orderButton.Click += OrderButton_Click;
            this._cancelButton.Click += CancelButton_Click;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.StartActivity(new Intent(this, typeof(HotDogMenuActivity)));
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            int amout = 0;
            int.TryParse(_amountEditText.Text, out amout);


            var intent = base.ActivityHelper.GetIntentWithExtra(new Dictionary<string, object>
            {
                { "Id" , _selectedHotDog.Id},
                {"amount" , amout }
            });

            SetResult(Result.Ok, intent);
            this.Finish();
        }

        private void BindData()
        {
            _hotDogNameTextView.Text = _selectedHotDog.Name;
            _hotDogDescriptionView.Text = _selectedHotDog.Description;
            _hotDogLabelDescriptionView.Text = _selectedHotDog.ShortDescription;
            _hotDogPriceTextView.Text = "Price: " + _selectedHotDog.Price;
            var image = ImageHelper.GetImageBitmapFromUrl("http://rustlersonline.com/wp-content/uploads/" + _selectedHotDog.ImagePath + ".png");
            _hotDogImageView.SetImageBitmap(image);
        }

        private void InitComponents()
        {
            _hotDogImageView = FindViewById<ImageView>(Resource.Id.hotDogImageView);
            _hotDogNameTextView = FindViewById<TextView>(Resource.Id.hotDogTextView);
            _hotDogLabelDescriptionView = FindViewById<TextView>(Resource.Id.hotDogLabelDescriptionView);
            _hotDogDescriptionView = FindViewById<TextView>(Resource.Id.hotDogDescriptionView);
            _hotDogPriceTextView = FindViewById<TextView>(Resource.Id.hotDogPriceTextView);
            _amountEditText = FindViewById<EditText>(Resource.Id.amountEditText);
            _cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            _orderButton = FindViewById<Button>(Resource.Id.orderButton);
        }
    }
}