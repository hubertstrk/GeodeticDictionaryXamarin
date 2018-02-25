using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace GeodeticDictionaryXamarin.ViewModel
{
    [ImplementPropertyChanged]
    public class TestViewModel
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
