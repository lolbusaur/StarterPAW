using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace StarterPAW.ViewModels
{
    public class ViewSuggestedViewModel : BaseViewModel
    {
        public ViewSuggestedViewModel()
        {
            Title = "Suggested Feeding Times";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.reddit.com/r/magicthecirclejerking")));
        }

        public ICommand OpenWebCommand { get; }

    }
}