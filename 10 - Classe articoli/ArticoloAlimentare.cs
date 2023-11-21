using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class ArticoloAlimentare : Articolo
    {
        protected string _anno;

        static int anno
        {
            get { return anno; }
            set { anno = value; }
        }

        public ArticoloAlimentare() 
        {
            anno = datatime.anno;
        }
    }
}
