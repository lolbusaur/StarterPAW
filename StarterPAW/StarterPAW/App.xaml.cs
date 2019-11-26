using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StarterPAW.Services;
using StarterPAW.Views;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using StarterPAW.Models;

namespace StarterPAW
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AsynchronousClient client = new AsynchronousClient("temp");
            client.StartClient();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

}
