using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RigioREST.Views;
using Xamarin.Forms;

namespace RigioREST
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountsListPage());
        }
    }
}
