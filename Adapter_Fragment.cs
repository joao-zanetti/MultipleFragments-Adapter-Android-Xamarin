using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using static Android.Graphics.ColorSpace;



namespace Fragment
{
    class Adapter_Fragment : FragmentPagerAdapter
    {

        public string[] titles = new string[] { "Tab1", "Tab2" };
        List<Android.Support.V4.App.Fragment> fgls = new List<Android.Support.V4.App.Fragment>();

        public Adapter_Fragment(Android.Support.V4.App.FragmentManager fm)
            : base(fm)
        {
            fgls.Add(Fragment_1.NewInstance());
            fgls.Add(Fragment_2.NewInstance());
        }

        public override int Count
        {
            get { return titles.Length; }
        }


        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return fgls[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(titles[position]);
        }


    }
}

