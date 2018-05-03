using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficodeTortuga
{
    class Piso
    {
        private int[,] piso = new int[20, 20];
        Pluma p = new Pluma();

        public string mostrar()
        {
            string cadena = "";

            for(int i = 0; i <20; i++)
            {
                for(int j =0; j< 20; j++)
                {
                    if(piso[i,j] == 1)
                    {
                        cadena += " + ";
                    }
                    else
                    {
                        cadena += " * ";
                    }
                    if(j == 19)
                    {
                        cadena += "\r\n";
                    }
                }
            }
            return cadena;
        }
        
        public void pintar(int distancia)
        {
            for(int i =0; i < distancia; i++)
            {
                if ( p.Plum == true)
                {
                    piso[p.Y,p.X] = 1;
                }
                p.avanzar();
            }
        }
         public void moverPluma()
        {
            p.moverPluma();
        }
        public void izq()
        {
            p.girarIzq();
        }
        public void derecha()
        {
            p.girarDerecha();
        }

        public string info()
        {
          return p.ToString();
        }
        public void reiniciar()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    piso[i, j] = 0;
                }
            }
        }
    }
}
