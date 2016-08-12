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

namespace RayTest.Droid
{
    [Activity(Label = "MenuActivity", MainLauncher = true)]
    public class MenuActivity : BaseCustomActivity
    {
        private Button orderButton;
        private Button cartButton;
        private Button aboutButton;
        private Button mapButton;
        private Button takePictureButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            base.SetContentView(Resource.Layout.MainMenu);
            this.InitComponents();
            this.BindEvents();
        }

        private void InitComponents()
        {
            orderButton = FindViewById<Button>(Resource.Id.orderButton);
            cartButton = FindViewById<Button>(Resource.Id.cartButton);
            aboutButton = FindViewById<Button>(Resource.Id.aboutButton);
            mapButton = FindViewById<Button>(Resource.Id.mapButton);
            takePictureButton = FindViewById<Button>(Resource.Id.takePictureButton);
        }

        private void BindEvents()
        {
            orderButton.Click += delegate { base.ActivityHelper.InitNewActivity<HotDogMenuActivity>(); };
            aboutButton.Click += delegate { base.ActivityHelper.InitNewActivity<AboutActivity>(); };
        }
    }
}