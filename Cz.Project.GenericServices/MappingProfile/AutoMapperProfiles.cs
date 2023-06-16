using AutoMapper;
using Cz.Project.Abstraction;
using Cz.Project.Abstraction.Log_Process;
using Cz.Project.Domain;
using Cz.Project.Dto;

namespace Cz.Project.GenericServices
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() { }

        public MapperConfiguration MapConfig()
        {
            return new MapperConfiguration(cfg =>
            {
                // --------------- AdminUsers ---------------

                cfg.CreateMap<AdminUsers, AdminUserDto>(MemberList.None)
                    .ForMember(dest => dest.Name, src => src.MapFrom(v => v.Name))
                    .ForMember(dest => dest.Password, src => src.MapFrom(v => v.Password))
                    .ForMember(dest => dest.Key, src => src.MapFrom(v => v.Key));

                // Dto to Domain
                cfg.CreateMap<AdminUserDto, AdminUsers>(MemberList.None)
                    .ForMember(dest => dest.Name, src => src.MapFrom(v => v.Name))
                    .ForMember(dest => dest.Password, src => src.MapFrom(v => v.Password))
                    .ForMember(dest => dest.Key, src => src.MapFrom(v => v.Key));

                // --------------- Log ---------------

                cfg.CreateMap<LogDto, Log>(MemberList.None)
                    .ForMember(dest => dest.Message, src => src.MapFrom(v => v.Message))
                    .ForMember(dest => dest.LogCode, src => src.MapFrom(v => v.LogCode))
                    .ForMember(dest => dest.Type, src => src.MapFrom(v => v.Type));

                cfg.CreateMap<Log, LogDto>(MemberList.None)
                    .ForMember(dest => dest.Message, src => src.MapFrom(v => v.Message))
                    .ForMember(dest => dest.LogCode, src => src.MapFrom(v => v.LogCode))
                    .ForMember(dest => dest.Type, src => src.MapFrom(v => v.Type));

                // --------------- LogType ---------------

                cfg.CreateMap<LogTypeDto, LogType>(MemberList.None)
                    .ForMember(dest => dest.Code, src => src.MapFrom(v => v.Code))
                    .ForMember(dest => dest.Name, src => src.MapFrom(v => v.Name));

                cfg.CreateMap<LogType, LogTypeDto>(MemberList.None)
                    .ForMember(dest => dest.Code, src => src.MapFrom(v => v.Code))
                    .ForMember(dest => dest.Name, src => src.MapFrom(v => v.Name));

                // --------------- Languaje ---------------

                cfg.CreateMap<LanguajeDto, Languaje>(MemberList.None)
                    .ForMember(dest => dest.Code, src => src.MapFrom(v => v.Code))
                    .ForMember(dest => dest.Name, src => src.MapFrom(v => v.Name));

                cfg.CreateMap<Languaje, LanguajeDto>(MemberList.None)
                    .ForMember(dest => dest.Code, src => src.MapFrom(v => v.Code))
                    .ForMember(dest => dest.Name, src => src.MapFrom(v => v.Name));

                // --------------- Words ---------------

                cfg.CreateMap<WordDto, Word>(MemberList.None)
                    .ForMember(dest => dest.Code, src => src.MapFrom(v => v.Code))
                    .ForMember(dest => dest.Languaje, src => src.MapFrom(v => v.Languaje))
                    .ForMember(dest => dest.Text, src => src.MapFrom(v => v.Text));

                cfg.CreateMap<Word, WordDto>(MemberList.None)
                    .ForMember(dest => dest.Code, src => src.MapFrom(v => v.Code))
                    .ForMember(dest => dest.Languaje, src => src.MapFrom(v => v.Languaje))
                    .ForMember(dest => dest.Text, src => src.MapFrom(v => v.Text));
            });
        }
    }
}
