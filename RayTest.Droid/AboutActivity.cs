
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace RayTest.Droid
{
    [Activity(Label = "AboutActivity")]
    public class AboutActivity : BaseCustomActivity
    {
        private TextView phoneNumberTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            base.SetContentView(Resource.Layout.AboutView);
            this.InitComponents();
            this.BindEvents();
        }

        private void InitComponents()
        {
            phoneNumberTextView = FindViewById<TextView>(Resource.Id.phoneNumberTextView);
        }

        private void BindEvents()
        {
            phoneNumberTextView.Click += delegate
            {
                base.ActivityHelper.InitNewActivity(Intent.ActionCall, Android.Net.Uri.Parse("tel:" + phoneNumberTextView.Text));
            };
        }
    }
}