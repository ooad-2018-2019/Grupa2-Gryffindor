using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAPI.Models
{
    public class Knjiga
    {
        [ScaffoldColumn(false)] public int ID { get; set; }
        [Required] public string Naslov { get; set; }
        [Required] public string Autor { get; set; }
        [Required] public double Cijena { get; set; }
        [Required] public int Kolicina { get; set; }
    }
}
