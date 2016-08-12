
using Android.App;
using Android.OS;
using RayTest.Droid.Utility;

namespace RayTest.Droid.Fragments
{
    public abstract class BaseCustomFragment : Fragment
    {
        protected ActivityHelperBase ActivityHelper
        {
            get; set;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            this.ActivityHelper = new ActivityHelperBase(this.Activity);
        }
    }
}