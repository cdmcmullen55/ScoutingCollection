﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoutingCollection
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PitScoutingReport : ContentPage
	{
		public PitScoutingReport ()
		{
			InitializeComponent ();
		}

        private void CancelPitScout_Clicked(object sender, EventArgs e)
        {

        }

        private void SaveReport_Clicked(object sender, EventArgs e)
        {

        }
    }
}