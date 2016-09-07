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

namespace DunamisandDynamic
{
    class DynamicTest
    {
        public static List<DynamicGS> testMett = new List<DynamicGS>()
        {
            new DynamicGS() {name = "Male" },
            new DynamicGS() {name = "Female" },
            new DynamicGS() {name = "Children" },
            new DynamicGS() {name = "Teenagers" },
            new DynamicGS() {name = "Offering" }
        };
    }       
}