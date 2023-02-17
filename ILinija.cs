using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linije_73_2019
{
    public interface ILinija
    {
        void ubaciRezulatate(int Id, int Poeni, String Timer, DateTime Datum);
        string dajNajboljiRezultat();
    }
}
