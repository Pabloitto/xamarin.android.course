using Android.Widget;
using RaysTest.Core.Model;
using System.Collections.Generic;

namespace RayTest.Droid.Fragments
{
    public class BaseFragment : BaseCustomFragment
    {
        protected ListView ListView;
        protected List<HotDog> HotDogs;

        public BaseFragment()
        {

        }

        protected void BindEvents()
        {
            this.ListView.ItemClick += HotDogLostView_ItemClick;
        }

        private void HotDogLostView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            base.ActivityHelper.InitNewActivity<HotDogDetailActivity>(new Dictionary<string, object>
            {
                { "Id" , this.HotDogs[e.Position].Id}
            }, this.ActivityHelper.RequestCode);
        }

        protected void InitComponents()
        {
            this.ListView = this.View.FindViewById<ListView>(Resource.Id.hotDogListView);
        }
    }
}