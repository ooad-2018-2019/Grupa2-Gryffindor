using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAPI.Models
{
    public class Narudzba
    {
        [ScaffoldColumn(false)] public int ID { get; set; }
        public List<Knjiga> ListaKnjiga { get; set; }
    }
}
