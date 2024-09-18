using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Notify.Albums
{
    public class Album : AggregateRoot<int>
    {
        public string Title { get; set; }
        // aca tienen que ir todos los atributos
    }
}
