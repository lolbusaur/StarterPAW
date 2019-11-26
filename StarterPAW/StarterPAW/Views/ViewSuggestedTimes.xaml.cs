using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.Generic;
using StarterPAW.Models;

namespace StarterPAW.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void DisplayPrompt (object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Schedule Select", "Would you like to calculate the optimized time to feed your cat daily?", "Yes", "No");
            if (answer)
            {
                //List<Item> TimeList = GetTimes();
            }
            else
            {
                
            }
        }
    }
}