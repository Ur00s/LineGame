using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linije_73_2019
{
    public class Dugme : PictureBox
    {
        int i;
        int j;
        public Dugme(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        public int I
        {
            get { return i; }
            set { i = value; }
        }

        public int J
        { 
            get { return j; }
            set { j = value; }
        }
    }
}
