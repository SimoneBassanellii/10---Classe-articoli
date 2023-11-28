using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _10___Classe_articoli
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public string[] Scontrino = new string[1000];
        private void Form1_Load(object sender, EventArgs e)
        {
            Articolo prova = new Articolo(Codice,Name, Prezzo, Carta);
        } 
    }
}