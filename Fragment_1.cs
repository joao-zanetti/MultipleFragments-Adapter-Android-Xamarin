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
    public class Fragment_1 : Android.Support.V4.App.Fragment
    {
        View view;

        public Fragment_1() { }

        public static Fragment_1 NewInstance()
        {
            Fragment_1 fragment = new Fragment_1();
            Bundle args = new Bundle();
            fragment.Arguments = args;

            return fragment;
        }

        //public override void OnCreate(Bundle savedInstanceState){base.OnCreate(savedInstanceState);}

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            view = inflater.Inflate(Resource.Layout.fragment_1, container, false);
            TextView frag = (TextView)view.FindViewById(Resource.Id.frag1);
            Button but = (Button)view.FindViewById(Resource.Id.but);


            return view;
        }

    }
}