using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using static Android.Views.ViewGroup;
using System.Collections.Generic;

namespace DunamisandDynamic
{
    [Activity(Label = "DunamisandDynamic", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

            LinearLayout ly = new LinearLayout(this);
            ly.Orientation = Orientation.Vertical;

            LinearLayout.LayoutParams lyParams = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.MatchParent);
            List<DynamicGS> storedValue = DynamicTest.testMett;
            int i = 0;
            foreach(DynamicGS newValue in storedValue)
            {
                TextView tv = new TextView(this);
                tv.RequestFocus();
                tv.Text = newValue.name;
                LinearLayout.LayoutParams tvParams = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);
                ly.AddView(tv, tvParams);

                EditText et = new EditText(this);
                et.RequestFocus();
                et.Hint = newValue.name;
                LinearLayout.LayoutParams etParams = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);
                ly.AddView(et, etParams);
            }
            Button bt = new Button(this);
            bt.Text = "Send";
            bt.SetBackgroundColor(
                Android.Graphics.Color.Black);         
            LinearLayout.LayoutParams btParams = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);
            ly.AddView(bt, btParams);


            SetContentView(ly, lyParams);
        }
    }
}

