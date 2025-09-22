using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet2
{
    internal class Aresta
    {
        private int aresta;
        private int area;

        public void setAresta(int aresta)
        {
            this.aresta = aresta;
        }

        public int getAresta()
        {
            return this.aresta;
        }

        public int getArea()
        {
            return this.area;
        }
        public void Arestaarea()
        {
            this.area = this.aresta * this.aresta;
        }
    }
}
