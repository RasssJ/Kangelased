using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelased
    {
        private string _nimi;
        private string _asukoht;

        public Kangelased(string nimi, string asukoht)

        {
            _nimi = nimi;
            _asukoht = asukoht;

        }

        public void SetNimi(string uusnimi) { _nimi = uusnimi; }
        public string GetNimi() { return _nimi; }

        public string GetAsukoht() { return _asukoht; }

        public void SetAsukoht(string uusasukoht) { _asukoht = uusasukoht; }


        public virtual int Päästa(int ohustatuid)
        {

            return ohustatuid * 95 / 100;
        }

        public override string ToString()
        {
            return $"{_nimi} kaitseb linna: {_asukoht}";
        }




    }

}



