using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linije_73_2019
{
    public class GameFactory
    {
        public static ILinija Game()
        {
            return new LinijaDb();
        }
    }
}
