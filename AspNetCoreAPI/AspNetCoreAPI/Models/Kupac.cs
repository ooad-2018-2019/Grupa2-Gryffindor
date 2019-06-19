using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAPI.Models
{
    public class Kupac
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required] public string Ime { get; set; }
        [Required] public string Prezime { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Sifra { get; set; }
        [Required] public string Grad { get; set; }
        [Required] public string Adresa { get; set; }
        [Required] public string Telefon { get; set; }
    }
}
