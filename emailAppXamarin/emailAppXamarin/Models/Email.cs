using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace emailAppXamarin.Models
{
    public class Email :INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Email(string title, string description, string to, string body)
        {
            Title = title;
            Description = description;
            Date = DateTime.Now;
            To = to;
            Body = body;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Body { get; set; }

        public string To { get; set; }
    }
}