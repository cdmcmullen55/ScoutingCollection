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
	public partial class PostMatchScoutPage : ContentPage
	{
        public MatchScoutAutoPage page;

        public PostMatchScoutPage ()
		{
			InitializeComponent ();
		}

        public PostMatchScoutPage(MainViewModel mvm, MatchScoutAutoPage prev_page)
        {
            BindingContext = mvm;
            page = prev_page;
            InitializeComponent();
        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync(false);
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}