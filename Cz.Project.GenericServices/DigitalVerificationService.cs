using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.GenericServices
{
    public class DigitalVerificationService
    {
        public IMapper mapper;

        public DigitalVerificationService()
        {
            var config = new AutoMapperProfiles();
            mapper = new Mapper(config.MapConfig());
        }

        public void VerificateDatabaseIntegrity()
        {

        }
    }
}
