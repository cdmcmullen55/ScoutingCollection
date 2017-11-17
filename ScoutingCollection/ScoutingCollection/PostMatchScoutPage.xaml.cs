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

        async void SaveReport_Clicked(object sender, EventArgs e)
        {
            var save = await DisplayAlert("Save Results?", "Changes cannot be made later.", "Save", "Cancel");
            if (save)
            {
                int initialcount = (BindingContext as MainViewModel).reports.Count();
                (BindingContext as MainViewModel).reports.Add((BindingContext as MainViewModel).currentReport);
                int newcount = (BindingContext as MainViewModel).reports.Count();
                if (newcount > initialcount)
                {
                    await DisplayAlert("Saved!", null, "Ok");
                    (BindingContext as MainViewModel).currentReport.generatePreview();
                    Cancel_Clicked(sender, e);
                }
                else
                {
                    await DisplayAlert("Error", "The report was not saved.", "Ok");
                }
            }
        }
    }
}