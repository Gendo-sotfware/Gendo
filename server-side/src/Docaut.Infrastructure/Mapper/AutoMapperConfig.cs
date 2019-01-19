using AutoMapper;
using Docaut.Core.Domain;
using Docaut.Infrastructure.DTO;
using Newtonsoft.Json.Linq;

namespace Docaut.Infrastructure.Mapper
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            return new MapperConfiguration(config => 
            {
                config.RecognizePrefixes("User");
                config.RecognizeDestinationPrefixes("User");
                config.CreateMap<User, Database.Models.User>().ReverseMap();
                config.CreateMap<Template, Database.Models.Template>().ReverseMap();
                config.CreateMap<Template, Database.Models.TemplateVersion>().ReverseMap();
                    
                config.CreateMap<User, UserDto>().ReverseMap();
            })
            .CreateMapper();
        } 
    }
}