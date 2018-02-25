using System;
using System.Collections.Generic;

namespace GeodeticDictionaryXamarin
{
    public class TranslationsDto
    {
        public List<TranslationDto> Value { get; set; }
    }

    public class TranslationDto
    {
        public int Id { get; set; }

        public string German { get; set; }

        public string English { get; set; }
    }
}
