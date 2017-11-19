using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastouderAdmin.Models
{
    public class Gastouder
    {
        public int Id { get; set; }
        public string Achternaam { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public Consulent Consulent { get; set; }
        public string Starttraject { get; set; }
        public bool PedBeleid { get; set; }
        public bool PedWerkplan { get; set; }
        public bool Huisregels { get; set; }
        public bool GoPlan { get; set; }
        public bool Tink { get; set; }      
    }
}
