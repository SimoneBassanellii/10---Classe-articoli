using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    internal class Articolo
    {
        protected int _codice;
        protected string _name;
        protected double _prezzo;
        protected bool _carta = false;


        static int codice
        {
            get { return codice;}
            set { codice = value;}
        }
        static string name
        {
            get { return name;}
            set { name = value;}
        }
        static double prezzo 
        {
            get { return prezzo;}
            set 
            {
                if(prezzo > 0) 
                {
                    prezzo = value;
                }
                else
                {
                    Console.WriteLine(Console.Error);                  
                }
            }
        }
        public Articolo(int Codice, string Name, double Prezzo, bool Carta)
        {
            this._codice = Codice;
            this._name = Name;
            this._prezzo = Prezzo;
            this._carta = Carta;
        }

        public double Sconto
        {
            get
            {
                if(_carta == true )
                {
                    return _prezzo = _prezzo - (_prezzo / 100) * 5;
                }
                else
                {
                    return _prezzo;
                }
            }
        }


    }
}
