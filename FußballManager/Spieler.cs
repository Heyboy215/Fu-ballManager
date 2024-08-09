using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FußballManager
{
    public class Spieler
    {
        public string filepath;

        public string Mannschaftsname;
        public string Spielername;
        public string Staatsangehörigkeit;
        public string Geburtstag;
        public string Geburtsort;
        public int Alter;
        public string Größe;
        public string Position;
        public string Transferwert;
        public string AktNationalspieler;
        public string LänderspieleTore;

        public Spieler(string Mannschaftsname, string Spielername, string Staatsangehörigkeit, string Geburtstag, string Geburtsort, int Alter, string Größe, string Position, string Transferwert, string AktNationalspieler, string LänderspieleTore)
        {
            this.Mannschaftsname = Mannschaftsname;
            this.Spielername = Spielername;
            this.Staatsangehörigkeit = Staatsangehörigkeit;
            this.Geburtstag = Geburtstag;
            this.Geburtsort = Geburtsort;
            this.Alter = Alter;
            this.Größe = Größe;
            this.Position = Position;
            this.Transferwert = Transferwert;
            this.AktNationalspieler = AktNationalspieler;
            this.LänderspieleTore = LänderspieleTore;
        }
    }
}