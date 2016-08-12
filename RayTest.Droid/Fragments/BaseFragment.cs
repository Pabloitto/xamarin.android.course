using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using RaysTest.Core.Model;
using RayTest.Droid.Adapters;

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