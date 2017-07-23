using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RigioREST.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RigioREST.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountDetailsPage : ContentPage
    {
        public AccountDetailsPage(Account selectedAccountt)
        {
            InitializeComponent();

            GridDetails.BindingContext = selectedAccountt;
        }
    }
}