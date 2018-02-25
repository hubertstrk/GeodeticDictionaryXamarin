using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using Xamarin.Forms;

namespace GeodeticDictionaryXamarin
{
    [ImplementPropertyChanged]
    public class TranslationViewModel
    {
        private readonly SearchService _SearchService;
        private ObservableCollection<TranslationModel> _Translations = new ObservableCollection<TranslationModel>();

        public TranslationViewModel()
        {
            _SearchService = new SearchService();
            SearchCommand = new Command<string>(async text => await AzureSearchAsync(text));
        }

        public ICommand SearchCommand { get; private set; }

        public ObservableCollection<TranslationModel> Translations { get; set; }

        private async Task AzureSearchAsync(string text)
        {
            if (string.IsNullOrEmpty(text)) return;

            var translationsDto = await _SearchService.GetTranslationsAsync(text);
            Translations =
                new ObservableCollection<TranslationModel>(translationsDto.Value.Select(s => new TranslationModel(s)));
        }
    }
}