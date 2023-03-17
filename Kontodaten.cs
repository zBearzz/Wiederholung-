using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alles_wiederholen
{
    class Kontodaten
    {
        public int MaNr { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Kennung { get; set; }
        public string Kennwort { get; set; }

        public Kontodaten()
        {

        }
        public void info(int MaNr, string Nachname, string Vorname, string Kennung, string Kennwort)
        {
            this.MaNr = MaNr;
            this.Nachname = Nachname;
            this.Vorname = Vorname;
            this.Kennung = Kennung;
            this.Kennwort = Kennwort;
        }

    }
}
