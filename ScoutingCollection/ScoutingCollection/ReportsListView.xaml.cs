using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoutingCollection
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportsListView : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }

        public ReportsListView()
        {
            InitializeComponent();
        }

        public ReportsListView(MainViewModel mvm)
        {
            InitializeComponent();
            BindingContext = mvm;
        }

        void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            //((ListView)sender).SelectedItem = null;
        }

        async void return_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void ExportAll_Clicked(object sender, EventArgs e)
        {
            (BindingContext as MainViewModel).Export();
        }

        async void OnEdit(object sender, EventArgs e)
        {
            if(((sender as MenuItem).BindingContext as ScoutVM).isMatch)
            {
                await DisplayAlert("Edit this match?", "", "Ok", "Cancel"); 
            }
            else
            {
                await DisplayAlert("Cannot edit matches", "", "Ok");
            }
        }

        public void OnDelete(object sender, EventArgs e)
        {

        }

        public void OnExport(object sender, EventArgs e)
        {

        }
    }
}