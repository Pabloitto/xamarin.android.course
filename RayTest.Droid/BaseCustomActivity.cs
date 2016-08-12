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