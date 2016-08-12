using Android.OS;
using Android.Views;
using RayTest.Droid.Adapters;
using System.Linq;

namespace RayTest.Droid.Fragments
{
    public class MeatLoversFragment : BaseFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            base.InitComponents();
            base.BindEvents();
            HotDogs = base.ActivityHelper.FetchHotDogs().Take(2).ToList();
            this.ListView.Adapter = new HotDogListAdapter(this.Activity, this.HotDogs);
            this.ListView.FastScrollEnabled = true;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.FavoriteHotDogFragment, container, false);
        }
    }
}