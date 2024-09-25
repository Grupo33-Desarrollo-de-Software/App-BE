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
        // aca tienen que ir todos los atributos
        public string Title { get; set; }

        public TypeGenre Genre { get; set; }

        public DateTime releaseDate{ get; set; } // esto nos devuelve con la hora, cosa que no nos interesa, cambiar

        public TimeSpan length{ get; set; }
       
        public string country {  get; set;}
      
        public bool released   { get; set; }

        public uint playCount { get; set; }
        // ver lo de la tapa del album
        // ver lo de agregar rating, ya que lleva la review

    }
}
