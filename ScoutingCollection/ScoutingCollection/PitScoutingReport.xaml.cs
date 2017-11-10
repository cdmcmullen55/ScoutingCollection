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
	public partial class PitScoutingReport : ContentPage
	{
		public PitScoutingReport ()
		{
			InitializeComponent ();
		}

        async void CancelPitScout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
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
                    await Navigation.PopModalAsync();
                }
                else
                {
                    await DisplayAlert("Error", "The report was not saved.", "Ok");
                }
            }
        }

        private void generatePreviewWrap(object sender, ToggledEventArgs e)
        {
            (BindingContext as MainViewModel).CurrentReport.generatePreview();

            //(BindingContext as MainViewModel).CurrentReport.Preview = "test";
        }
    }
}