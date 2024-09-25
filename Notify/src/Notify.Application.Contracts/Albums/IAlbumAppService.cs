using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Notify.Albums
{
    public interface IAlbumAppService : ICrudAppService<AlbumDto, int, PagedAndSortedResultRequestDto, CreateUpdateAlbumDto, CreateUpdateAlbumDto>
    {
    }
}
