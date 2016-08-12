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
using RayTest.Droid.Adapters;
using RaysTest.Core.Repository;
using RayTest.Droid.Fragments;

namespace RayTest.Droid
{
    [Activity(Label = "HotDogMenuActivity", MainLauncher = false)]
    public class HotDogMenuActivity : BaseCustomActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            base.SetContentView(Resource.Layout.HotDogMenuView);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            this.AddTab("Favorites", Resource.Drawable.Icon, new FavoriteHotDogFragment());
            this.AddTab("Meat lovers", Resource.Drawable.Icon, new MeatLoversFragment());
            this.AddTab("Veggie Lovers", Resource.Drawable.Icon, new VeggieLoversFragment());
        }

        private void AddTab(string tabText, int iconResourceId , Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);
            tab.SetIcon(iconResourceId);
            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
             {
                 var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                 if(fragment != null)
                 {
                     e.FragmentTransaction.Remove(fragment);
                 }
                 e.FragmentTransaction.Add(Resource.Id.fragmentContainer, view);
             };

            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                e.FragmentTransaction.Remove(view);
            };

            this.ActionBar.AddTab(tab);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok && requestCode == this.ActivityHelper.RequestCode)
            {
                int paramId = base.ActivityHelper.GetValueFromExtras<int>(data, "Id");
                int amount = base.ActivityHelper.GetValueFromExtras<int>(data, "amount");
                HotDog selected = base.ActivityHelper.FindSelectedHotDog(paramId);
                var dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("Confirmation");
                dialog.SetMessage(string.Format("You have added {0} time(s) the {1}", amount, selected.Name));
                dialog.Show();
            }
        }
    }
}