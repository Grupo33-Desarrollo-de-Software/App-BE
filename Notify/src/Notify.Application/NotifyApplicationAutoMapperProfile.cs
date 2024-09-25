using AutoMapper;
using Notify.Albums;

namespace Notify;

public class NotifyApplicationAutoMapperProfile : Profile
{
    public NotifyApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Album, AlbumDto>();
        CreateMap<CreateUpdateAlbumDto,Album>();
    }
}
// si hay algun dato distinto, hay que definir la transformacion en el mapeo