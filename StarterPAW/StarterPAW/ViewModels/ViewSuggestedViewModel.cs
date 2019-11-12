using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace StarterPAW.ViewModels
{
    public class ViewSuggestedViewModel : BaseViewModel
    {
        public ViewSuggestedViewModel()
        {
            Title = "Suggested Feeding Times";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}