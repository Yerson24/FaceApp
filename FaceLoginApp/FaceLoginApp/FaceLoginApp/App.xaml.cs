using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaceLoginApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Paginas.PaginaLogin());
        }

        protected override void OnStart()
        {
            //Handle When your app starts 
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
