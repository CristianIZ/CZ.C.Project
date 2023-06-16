using AutoMapper;
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
        public IMapper mapper;

        public TranslationService()
        {
            var config = new AutoMapperProfiles();
            mapper = new Mapper(config.MapConfig());
        }

        public void ChangeLenguaje(LanguajesCodeEnum languaje)
        {

        }

        public IList<LanguajeDto> GetLanguages()
        {
            var languajeContext = new LanguajesContext();
            return mapper.Map<IList<LanguajeDto>>(languajeContext.GetAll());
        }

        public IList<WordDto> GetWords(LanguajesCodeEnum languajeCode)
        {
            var wordContext = new WordContext();
            return mapper.Map<IList<WordDto>>(wordContext.GetWordsByLanguaje((int)languajeCode));
        }
    }
}
