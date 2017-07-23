using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RigioREST.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RigioREST.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountsListPage : ContentPage
    {
        public AccountsListPage()
        {
            InitializeComponent();
            GetAccounts();
        }

        private async void GetAccounts()
        {
            if (NetworkCheck.IsInternet())
            {
                listviewAccounts.ItemsSource = await App.AccountManager.GetAccountsAsync();
            }
            else
            {
                await DisplayAlert("Rigio", "No network is available.", "Ok");
            }
            //Hide loader after server response  
                ProgressLoader.IsVisible = false;
        }

       

        private void listviewAccounts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelectedData = e.SelectedItem as Account;
            Navigation.PushAsync(new AccountDetailsPage(itemSelectedData));
        }
    }
}
