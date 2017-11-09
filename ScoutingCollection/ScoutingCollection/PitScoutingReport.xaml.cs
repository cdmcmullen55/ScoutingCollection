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
                (BindingContext as MainViewModel).reports.Add((BindingContext as MainViewModel).currentReport);
                await Navigation.PopModalAsync();
            }
        }

        private void generatePreviewWrap(object sender, ToggledEventArgs e)
        {
            (BindingContext as MainViewModel).CurrentReport.generatePreview();

            //(BindingContext as MainViewModel).CurrentReport.Preview = "test";
        }
    }
}