using Notify.Albums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Notify.ListenLists
{
    public class ListenListAppService : ApplicationService, IListenListAppService // relacionada con una vision vinculada al CdU
    {
        private readonly IRepository<ListenList, int> _listenListRepository;
        private readonly IRepository<Album,int> _albumRepository;
        // accedemos a los repositorios mediante un constructor que recibe los objetos
        public ListenListAppService(IRepository<ListenList, int> listenListRepository, IRepository<Album, int> albumRepository)
        {
            _albumRepository = albumRepository;
            _listenListRepository = listenListRepository;
        }
        public async Task AddAlbumAsync(int albumId)
        {
            var listenlist = ((List<ListenList>)await _listenListRepository.GetListAsync()).FirstOrDefault();
            //implementamos la incorporacion de un album

            if (listenlist == null) // si la lista es nula, la creo y la inserto al repositorio
            {
                listenlist = new ListenList();
                await _listenListRepository.InsertAsync(listenlist);
            }
            // con el albumid obtengo el objeto album
            var album = await _albumRepository.GetAsync(albumId);
            listenlist.Albums.Add(album);
            await _listenListRepository.UpdateAsync(listenlist);    
        }
    }
}
