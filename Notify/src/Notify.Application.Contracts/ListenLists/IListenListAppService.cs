using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Notify.ListenLists
{
    public interface IListenListAppService : IApplicationService
    {
        Task AddAlbumAsync (int albumId);
    }
}
// vamos a implementar metodo por metodo, por eso no utilizamos el crud
// esto se puede hacer con un Dto en su lugar, pero el profe en el video no lo usa
// sin embargo, en el tutorial q seguimos si lo usan
// estamos implementando la lista de seguimiento sin referir al usuario, cosa que vamos a tener que implementar mas tarde
// task async: tarea asincronica 