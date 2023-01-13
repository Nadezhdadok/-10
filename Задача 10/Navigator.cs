using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    internal class Navigator
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
               gradus = value % 360;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                Gradus += value / 360;
                min = value % 60;
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                Min += value / 60;
                sec = value % 60;
            }
        }

        public Navigator(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public double ToRadians()
        {
            return sec + min * ((Math.PI) / 648000) + gradus * (((Math.PI) / 648000) * ((Math.PI) / 10800));
        }
    }
}
