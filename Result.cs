using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linije_73_2019
{
    public class Result
    {
        private int id;
        private int points;
        private string timer;
        private DateTime datum;

        public int Id { get { return id; } set { } }
        public int Points { get { return points; } set { } }
        public string Timer { get { return timer; } set { } }
        public DateTime Datum { get { return datum; } set { } }

        public Result(int Id, int Points, string Timer, DateTime Datum)
        {
            this.id = Id;
            this.points = Points;
            this.timer = Timer;
            this.datum = Datum;
        }
    }
}
