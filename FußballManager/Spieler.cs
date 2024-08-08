using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FußballManager
{
    public class Spieler
    {
        public string Mannschaftsname;
        public string Spielername;
        public int Alter;
        public string Größe;
        public string Position;
        public string Transferwert;
        public string LänderspieleTore;

        public Spieler(string Mannschaftsname, string Spielername, int Alter, string Größe, string Position, string Transferwert, string LänderspieleTore) 
        {
            this.Mannschaftsname = Mannschaftsname;
            this.Spielername = Spielername;
            this.Alter = Alter;
            this.Größe = Größe;
            this.Position = Position;
            this.Transferwert = Transferwert;
            this.LänderspieleTore = LänderspieleTore;
        }
    }
}