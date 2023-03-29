using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2jsjs
{
    class Circulo
    {
        private float radius;

        public Circulo(float radius)
        {
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
