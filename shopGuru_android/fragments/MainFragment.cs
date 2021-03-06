﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace shopGuru_android.fragments
{
    public class MainFragment : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment_main, container, false);

            var scanBtn = view.FindViewById(Resource.Id.btnScanReceipt);

            scanBtn.Click += ScanBtn_Click;
            base.OnCreateView(inflater, container, savedInstanceState);
            return view;
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this.Context, typeof(ScanActivity));
            
            this.Activity.StartActivityForResult(intent, MainActivity.requestScannerId);
        }
    }
}