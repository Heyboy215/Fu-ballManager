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
        public string Position;
        public string Transferwert;

        public Spieler(string Mannschaftsname, string Spielername, int Alter, string Position, string Transferwert) 
        {
            this.Mannschaftsname = Mannschaftsname;
            this.Spielername = Spielername;
            this.Alter = Alter;
            this.Position = Position;
            this.Transferwert = Transferwert;
        }
    }
}