using Roster.Client.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title = "Roster App";

        public string Title 
        { 
            get => _title;
            set 
            {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public ObservableCollection<Person> People { get; set; }

        public Command UpdateApplicationCommand { get; set; }

        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationCommandExecute);

            People = new ObservableCollection<Person>
            {
                new Person()
                {
                    Name = "",
                    Company = ""
                },
                new Person()
                {
                    Name = "Delores Feil",
                    Company = "Legros Group"
                },
                new Person()
                {
                    Name = "Ann Zboncak",
                    Company = "Ledner - Ferry"
                },
                new Person()
                {
                    Name = "Jaime Lesch",
                    Company = "Herzog and Sons"
                }
            };
         }

        private void UpdateApplicationCommandExecute()
        {
            Title = "Roster App (v2.0)";
        }
    }
}
