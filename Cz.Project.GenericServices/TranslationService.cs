using Cz.Project.Abstraction;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Domain;
using Cz.Project.SQLContext.Services;
using System.Collections.Generic;
using System.Linq;

namespace Cz.Project.GenericServices
{
    public class TranslationService
    {
        public void ChangeLenguaje(LanguajesCodeEnum languaje)
        {

        }

        public IList<WordDto> GetWords(LanguajesCodeEnum languajeCode)
        {
            var wordContext = new WordContext();
            return MapWords(wordContext.GetWordsByLanguaje((int)languajeCode));
        }

        public IList<WordDto> MapWords(IList<Word> words)
        {
            return words.Select(w => new WordDto()
            {
                Code = w.Code,
                Translate = w.Translate,
                Languaje = MapLanguaje(w.Languaje)
            }).ToList();
        }

        public LanguajeDto MapLanguaje(Languaje languaje)
        {
            return new LanguajeDto()
            {
                Code = languaje.Code,
                Name = languaje.Name
            };
        }
    }
}
