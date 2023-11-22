using System;

public class Class1
{
    //crea la classe ArticoloAlimentareFresco cjhe eredita da ArticoloAlimentare e per gli articoli alimentari freschi, per gli articoli alimentari freschi, lo sconto aggiuntivo sarà del 2% per il numero di giorni in cui deve essere consumato, considerato in proporzione inversa: es. 2% per 5 giorni, 4% per 4 giorni.... 10% per 1 giorno.

    public class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        public int giorni { get; set; }

        public ArticoloAlimentareFresco(string codice, string descrizione, double prezzo, DateTime dataScadenza, int giorni) : base(codice, descrizione, prezzo, dataScadenza)
        {
            Giorni = giorni;
        }

        public override double Sconto()
        {
            if (giorni == 1)
            {
                return Prezzo * 0.1;
            }
            else if (giorni == 2)
            {
                return Prezzo * 0.08;
            }
            else if (giorni == 3)
            {
                return Prezzo * 0.06;
            }
            else if (giorni == 4)
            {
                return Prezzo * 0.04;
            }
            else if (giorni == 5)
            {
                return Prezzo * 0.02;
            }
            else
            {
                return Prezzo;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
