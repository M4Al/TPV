using PP.Attractions;
using AutoMapper;

namespace PP
{
    public class PPApplicationAutoMapperProfile : Profile
    {
        public PPApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Attraction, AttractionDto>();
            CreateMap<CreateUpdateAttractionDto, Attraction>();
        }
    }
}
