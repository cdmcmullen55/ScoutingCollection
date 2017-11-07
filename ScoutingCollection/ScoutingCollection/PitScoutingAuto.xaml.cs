using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoutingCollection
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PitScoutingAuto : ContentPage
	{
		public PitScoutingAuto ()
		{
			InitializeComponent ();
		}

        private void Start_Pos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}