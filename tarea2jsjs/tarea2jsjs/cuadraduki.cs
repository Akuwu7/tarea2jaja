using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2jsjs
{
    class cuadraduki : formita

    {
        private float side;

        public cuadraduki(float side)
        {
            this.side = side;
        }

        public override float CalculateArea()
        {
            return side * side;
        }
    }
}
