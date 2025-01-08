using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Class1
    {
        public string Nazwa {  get; set; }
        public float Cena { get; set; }
        public string Opis { get; set; }
        public bool Dostepny { get; set; }
        public string Kategoria { get; set; }
       

        public Class1(string nazwa, float cena, string opis,bool dostepny, string kategoria)
        {
            Nazwa = nazwa;
            Cena = cena;
            Opis = opis;
            Dostepny = dostepny;
            Kategoria = kategoria;
            
        }
    }
}
