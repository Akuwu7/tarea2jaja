using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2jsjs
{
    class Rectangulo : formita
    {
        private float b;
        private float h;

        public Rectangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public override float CalculateArea()
        {
            return b * h;
        }
    }
}
