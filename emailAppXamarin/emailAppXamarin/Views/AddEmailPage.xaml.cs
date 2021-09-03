using emailAppXamarin.Models;
using emailAppXamarin.ViewModels;
using System.Collections.ObjectModel;

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