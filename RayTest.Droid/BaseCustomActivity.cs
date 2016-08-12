
using Android.App;
using Android.OS;
using RayTest.Droid.Utility;

namespace RayTest.Droid
{
    [Activity(Label = "BaseCustomActivity")]
    public class BaseCustomActivity : Activity
    {
        protected ActivityHelperBase ActivityHelper
        {
            get; set;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.ActivityHelper = new ActivityHelperBase(this);

        }
    }
}