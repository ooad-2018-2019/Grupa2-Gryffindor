using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DreamBook.Models
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

    public class Profil
    {
        [ScaffoldColumn(false)] public int ID { get; set; }

        public List<Knjiga> ListaZelja { get; set; }

    }

    public class Knjiga
    {
        [ScaffoldColumn(false)] public int ID { get; set; }
        [Required] public string Naslov { get; set; }
        [Required] public string Autor { get; set; }
        [Required] public double Cijena { get; set; }
        [Required] public int Kolicina { get; set; }
    }

    public class Administrator
    {
        [ScaffoldColumn(false)] public int ID { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Sifra { get; set; }


    }


    public class Gost
    {


    }

    public class Narudzba
    {
        [ScaffoldColumn(false)] public int ID { get; set; }
        public List<Knjiga> ListaKnjiga { get; set; }

    }


}