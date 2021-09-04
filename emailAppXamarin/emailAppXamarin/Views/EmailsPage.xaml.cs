using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emailAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailsPage : ContentPage
    {
        public EmailsPage()
        {
            InitializeComponent();
            //BindingContext = this;
        }

        //public EmailsPage(Email email) : this()
        //{
        //    _selectedEmail = email;
        //}
    }
}