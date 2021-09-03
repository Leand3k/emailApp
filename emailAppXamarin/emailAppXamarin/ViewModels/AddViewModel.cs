using emailAppXamarin.Models;
using emailAppXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace emailAppXamarin.ViewModels
{
    public class AddViewModel : BaseViewModel
    {
        private ObservableCollection<Email> _referenceEmail;
        

        public AddViewModel(ObservableCollection<Email> emails)
        {
            _referenceEmail = emails;
            AddEmailCommand = new Command(Add);
        }

        private async void Add()
        {
            var newEmail = new Email(Title, Description, To, Body);
            _referenceEmail.Add(newEmail);
            await App.Current.MainPage.Navigation.PopAsync();
        }


        public ICommand AddEmailCommand { get; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string To { get; private set; }
        public string Body { get; private set; }
    }
}
