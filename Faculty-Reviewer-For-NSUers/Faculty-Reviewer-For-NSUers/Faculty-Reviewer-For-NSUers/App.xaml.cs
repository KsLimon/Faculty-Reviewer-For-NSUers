using Faculty_Reviewer_For_NSUers.Services;
using Faculty_Reviewer_For_NSUers.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Faculty_Reviewer_For_NSUers
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
