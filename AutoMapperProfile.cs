using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            
            //As explained in the update method in controller,
            // here is the implementation of a map in the file using the second solution:
            //CreateMap<UpdateCharacterDto, Character>();
        }
    }
}