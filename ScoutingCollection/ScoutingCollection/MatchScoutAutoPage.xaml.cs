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
	public partial class MatchScoutAutoPage : ContentPage
	{
		public MatchScoutAutoPage (MainViewModel mvm)
		{
			InitializeComponent ();
            BindingContext = mvm;
		}

        async void back_Clicked(object sender , EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
	}
}