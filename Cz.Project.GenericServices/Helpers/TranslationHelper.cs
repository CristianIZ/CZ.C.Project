using Cz.Project.Abstraction.Enums;
using Cz.Project.Abstraction.Translation_Observer;
using Cz.Project.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.GenericServices.Helpers
{
    public static class TranslationHelper
    {
        public static Translation Translation = new Translation();

        public static LanguajesCodeEnum GetEnum(int code)
        {
            switch (code)
            {
                case (int)LanguajesCodeEnum.spanish:
                    return LanguajesCodeEnum.spanish;

                case (int)LanguajesCodeEnum.english:
                    return LanguajesCodeEnum.english;

                default:
                    throw new ApplicationException("Codigo no existente para el lenguaje especificado");
                    break;

            }
        }
    }
}
