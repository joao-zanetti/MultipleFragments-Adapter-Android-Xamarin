using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using System;

namespace Fragment
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ViewPager viewPager;
        Button buttonFrag1;
        Button buttonFrag2;
        Adapter_Fragment adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            viewPager = FindViewById<ViewPager>(Resource.Id.viewP);
            buttonFrag1 = FindViewById<Button>(Resource.Id.buttonFrag1);
            buttonFrag2 = FindViewById<Button>(Resource.Id.buttonFrag2);

            buttonFrag1.Click += clickFrag1;
            buttonFrag2.Click += clickFrag2;

            adapter = new Adapter_Fragment(SupportFragmentManager);     
        }

        private void clickFrag1(object sender, EventArgs e)
        {
            viewPager.Adapter = adapter;
            viewPager.SetCurrentItem(0, true);
        }

        private void clickFrag2(object sender, EventArgs e)
        {
            viewPager.Adapter = adapter;
            viewPager.SetCurrentItem(1, true);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

