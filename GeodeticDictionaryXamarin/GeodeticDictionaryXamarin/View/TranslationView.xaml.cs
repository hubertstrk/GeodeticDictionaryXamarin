using Xamarin.Forms;

namespace GeodeticDictionaryXamarin
{
    public partial class TranslationView : ContentPage
    {
        public TranslationView()
        {
            InitializeComponent();

            BindingContext = new TranslationViewModel();
        }
    }
}
