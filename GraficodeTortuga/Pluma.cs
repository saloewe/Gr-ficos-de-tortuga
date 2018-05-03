using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficodeTortuga
{
    class Pluma
    {
        private int x;
        private int y;
        private bool pluma = false;
        private int direccion;
     
        public Pluma()
        {
        }
        public bool Plum
        { get { return pluma; } }
        public int X
        { get { return x; } }
        public int Y
        { get { return y; } }

        public void avanzar()
        {
            if (direccion == 0)
            {
                if (x == 19)
                    x = 0;
                x++;  
            } else if (direccion == 1)
            {
                if (y == 19)
                    y = 0;
                y++;
            } else if (direccion == 2)
            {
                if (x == 0)
                    x = 19;
                x--;                
            } else
            {
                if (y == 0)
                    y = 19;
                y--;                
            }
        }

        public void girarIzq()
        {
            if (direccion == 0)
            {
                direccion = 3;
            }
            else
            {
                direccion--;
            }
        }

        public void girarDerecha ()
        {
            if (direccion == 3)
            {
                direccion = 0;
            }
            else
            {
                direccion++;
            }
        }

        public void moverPluma()
        {
            if(pluma == false)
            {
                pluma = true;
            }
            else
            {
                pluma = false;
            }
        }
        public override string ToString()
        {
            string cadena = "Direccion ";
            if (direccion == 0)
            {
                cadena += "derecha x:" + x + " y:" + y + " pluma "; 
            }
            else if (direccion == 1)
            {
                cadena+= "abajo x:" + x + " y:" + y + " pluma "; 
            }
            else if (direccion == 2)
            {
                cadena+= "izquierda x:" + x + " y:" + y + " pluma "; 
            }
            else
            {
                cadena += "arriba x:" + x + " y:" + y + " pluma "; 
            }

            if (pluma == false)
            {
                cadena += "arriba";
            }
            else
            {
                cadena += "abajo";
            }
            return cadena;
        }
        
            
   
                
    }
    
}
