using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class ArticoloAlimentare : Articolo
    {
        
        public DateTime DataScadenza { get; set; }

        public ArticoloAlimentare(string codice, string descrizione, double prezzo, DateTime dataScadenza) : base(codice, descrizione, prezzo)
        {
            DataScadenza = dataScadenza;
        }

        public override string ToString()
        { 
            return base.ToString() + $"Data scadenza: {DataScadenza.ToShortDateString()}";
        }



        
    }
}
