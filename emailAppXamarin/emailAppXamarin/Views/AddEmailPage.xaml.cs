
using emailAppXamarin.Models;
using emailAppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emailAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmailPage : ContentPage
    {
        public AddEmailPage(ObservableCollection<Email> emails)
        {
            InitializeComponent();
            BindingContext = new AddViewModel(emails);
        }
    }
}