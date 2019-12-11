using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using StarterPAW.Models;
using Xamarin.Forms;


namespace StarterPAW.ViewModels
{
    public class ViewSuggestedViewModel : BaseViewModel, INotifyPropertyChanged
    {
        string temperature, time;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Temperature
        {
            set
            {
                if(temperature != value)
                {
                    temperature = value;
                    OnPropertyChanged("Temperature");
                }
            }
            get
            {
                return temperature;
            }
        }

        public string Time
        {
            set
            {
                if(time != value)
                {
                    time = value;
                    OnPropertyChanged("Time");
                }
            }
        }

        public ViewSuggestedViewModel()
        {
            Title = "Suggested Feeding Times";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://10.16.219.247:8000")));

            NextFeeding = new Command(() =>
                {
                    AsynchronousClient client = new AsynchronousClient("next");
                    client.StartClient();
                });

            GetTemp = new Command(() =>
                {
                    AsynchronousClient client = new AsynchronousClient("temp");
                    client.StartClient();
                    temperature = client.GetResponse();
                });

            GetTime = new Command(() =>
                {
                    AsynchronousClient client = new AsynchronousClient("time");
                    client.StartClient();
                    time = client.GetResponse();
                });

        }

        public ICommand OpenWebCommand { get; }

        public ICommand NextFeeding { get; }

        public ICommand GetTemp { get; }

        public ICommand GetTime { get; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}