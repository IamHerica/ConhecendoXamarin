using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ConhecendoXamarin.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Página Inicial";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.instagram.com/iamhericaa/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}