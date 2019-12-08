using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using StarterPAW.Models;
using Xamarin.Forms;


namespace StarterPAW.ViewModels
{
    public class ViewSuggestedViewModel : BaseViewModel
    {
        public ViewSuggestedViewModel()
        {

            Title = "Suggested Feeding Times";
            AsynchronousClient client = new AsynchronousClient();
            
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://184.54.202.199:8000")));
            SendString = new Command(() => client.StartClient());
        }

        public ICommand OpenWebCommand { get; }

        public ICommand SendString { get; }

    }
}