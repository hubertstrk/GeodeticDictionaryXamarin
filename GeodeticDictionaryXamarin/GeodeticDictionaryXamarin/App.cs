using System;
using Akavache;
using Xamarin.Forms;

namespace GeodeticDictionaryXamarin
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage( new TranslationView() );

            Cache.Initialize(() => "gddictionary");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
