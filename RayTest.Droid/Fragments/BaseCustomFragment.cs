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