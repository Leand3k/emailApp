using emailAppXamarin.Models;
using emailAppXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace emailAppXamarin.ViewModels
{
    public class EmailsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Email> Emails { get; set; } = new ObservableCollection<Email>();

        private Email _selectedEmail;

        public Email SelectedEmail
        {
            get
            {
                return _selectedEmail;
            }
            set
            {
                _selectedEmail = value;

                if (_selectedEmail != null)
                {
                    SelectedEmailCommand.Execute(_selectedEmail);
                    SelectedEmail = null;
                }
            }
        }

        public EmailsViewModel()
        {
            SelectedEmailCommand = new Command<Email>(EmailsSelected);

            NavigateCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AddEmailPage(Emails)));
            });

            DeleteCommand = new Command<Email>(Delete);

            ViewEmailCommand = new Command<Email>(ViewEmail);
        }

        private async void ViewEmail(Email email)
        {
            await App.Current.MainPage.DisplayAlert("To: " + email.To, "Subject:" + email.Description + "\nBody:" + email.Body, "Done");
        }

        private async void EmailsSelected(Email email)
        {
            await App.Current.MainPage.Navigation.PushAsync(new EmailsPage());
        }

        private void Delete(Email email)
        {
            Emails.Remove(email);
        }

        public ICommand DeleteCommand { get; set; }
        public ICommand SelectedEmailCommand { get; }
        public ICommand NavigateCommand { get; }
        public ICommand ViewEmailCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}