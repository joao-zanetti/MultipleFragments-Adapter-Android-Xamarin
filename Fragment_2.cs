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

namespace Fragment
{
    public class Fragment_2 : Android.Support.V4.App.Fragment
    {
        View view;

        public Fragment_2() { }

        public static Fragment_2 NewInstance()
        {
            Fragment_2 fragment = new Fragment_2();
            Bundle args = new Bundle();
            fragment.Arguments = args;

            return fragment;
        }

        //public override void OnCreate(Bundle savedInstanceState){base.OnCreate(savedInstanceState);}

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            view = inflater.Inflate(Resource.Layout.fragment_2, container, false);
            TextView frag = (TextView)view.FindViewById(Resource.Id.frag2);
            return view;
        }

    }
}