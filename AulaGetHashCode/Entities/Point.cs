using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGetHashCode.Entities
{
    struct Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
        }
    }
}
