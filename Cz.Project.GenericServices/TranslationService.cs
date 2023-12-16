using AutoMapper;
using Cz.Project.Abstraction;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Domain;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cz.Project.GenericServices
{
    public class TranslationService
    {
        public IMapper mapper;

        public TranslationService()
        {
            var config = new AutoMapperProfiles();
            mapper = new Mapper(config.MapConfig());
        }

        public void AddLanguaje(string languajeText)
        {
            var languajeContext = new LanguajesContext();
            var languaje = languajeContext.GetByName(languajeText);

            if (languaje != null && languaje.Count > 0)
                throw new ApplicationException("El lenguaje ya existe");

            var languajes = languajeContext.GetAll();

            var lastLanguaje = languajes.OrderByDescending(x => x.Code).FirstOrDefault();

            languajeContext.Add(new Languaje()
            {
                Code = lastLanguaje.Code + 1,
                Name = languajeText
            });
        }

        public void AddWord(LanguajeDto sourceLanguaje, LanguajeDto targetLanguaje, WordDto sourceWord, string translation)
        {
            var wordContext = new WordContext();
            var languajeContext = new LanguajesContext();

            var sourceLang = languajeContext.GetByCode(sourceLanguaje.Code);
            var targetLang = languajeContext.GetByCode(targetLanguaje.Code);

            // Palabra fuente que se va a traducir (debe existir)
            var dbWord = wordContext.GetByCode(sourceWord.Code, sourceLang.Id);

            if (dbWord == null)
                throw new ApplicationException("La palabra que se intenta traducir no existe");

            var dbTranslation = wordContext.GetByCode(sourceWord.Code, targetLang.Id);

            if (dbTranslation == null)
            {
                wordContext.Add(new Word()
                {
                    Code = dbWord.Code,
                    LanguajeId = targetLang.Id,
                    Text = translation
                });
            }
            else
            {
                wordContext.Update(new Word()
                {
                    Code = dbTranslation.Code,
                    LanguajeId = dbTranslation.LanguajeId,
                    Id = dbTranslation.Id,
                    Text = translation
                });
            }
        }

        public IList<LanguajeDto> GetLanguages()
        {
            var languajeContext = new LanguajesContext();
            return mapper.Map<IList<LanguajeDto>>(languajeContext.GetAll()).OrderBy(a => a.Name).ToList();
        }

        public IList<WordDto> GetWords(LanguajeDto languajeCode)
        {
            var wordContext = new WordContext();
            return mapper.Map<IList<WordDto>>(wordContext.GetWordsByLanguaje(languajeCode.Code)).OrderBy(a => a.Text).ToList();
        }
    }
}
