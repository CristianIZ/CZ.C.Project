using Cz.Project.Abstraction.Enums;
using Cz.Project.Abstraction.Translation_Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Abstraction
{
    public class WordDto
    {
        public LanguajeDto Languaje { get; set; }
        public string Text { get; set; }
        public int Code { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
