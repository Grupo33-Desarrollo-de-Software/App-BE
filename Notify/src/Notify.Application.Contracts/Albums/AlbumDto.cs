using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Notify.Albums
{
    public class AlbumDto : EntityDto<int>
    {
        public string Title { get; set; }
        public TypeGenre Genre { get; set; }
        public DateTime releaseDate { get; set; }
        public TimeSpan length { get; set; }
        public string country { get; set; }
        public bool released { get; set; }
        public uint playCount { get; set; }
    }
}
// se utilizan para devolverle informacion al frontend de Album (entidad de dominio) o viceversa
// los atributos no necesariamente son iguales a los de la entidad de dominio