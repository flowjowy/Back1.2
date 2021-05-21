using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CollectionViewModel
    {
        public string CollectionInfo { get; set; }

        public List<CollectionElementViewModel> Elements { get; set; }
    }
}
