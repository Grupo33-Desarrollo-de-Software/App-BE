﻿using Notify.Albums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Notify.ListenLists
{
    public class ListenList : AggregateRoot<int>
    {
        public List<Album> Albums { get; set; }

        public ListenList()
        {
            Albums = new List<Album>();
        }
    }
}
