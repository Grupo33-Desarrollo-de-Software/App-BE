using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Notify.Albums
{
    public class AlbumAppService : CrudAppService<Album, AlbumDto, int, PagedAndSortedResultRequestDto, CreateUpdateAlbumDto, CreateUpdateAlbumDto>, IAlbumAppService
    {
        public AlbumAppService(IRepository<Album, int> repository) : base(repository) { }
    }

}
