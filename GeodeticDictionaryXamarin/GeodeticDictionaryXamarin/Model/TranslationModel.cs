using System;

namespace GeodeticDictionaryXamarin
{
    public class TranslationModel
    {
        public TranslationModel(TranslationDto dto)
        {
            Id = dto.Id;
            Primary = dto.German;
            Subsidiary = dto.English;
        }

        public int Id { get; set; }

        public string Primary { get; set; }

        public string Subsidiary { get; set; }

        public void ToModel(TranslationDto dto)
        {
            Id = dto.Id;
            Primary = dto.German;
            Subsidiary = dto.English;
        }
    }
}