using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
   public class Grupo
    {
        string nombre;
        Usuario parlamentario;
        Usuario[] asesores = new Usuario[8];
        int agregado = 0;

        public int getAgregado()
        {
            return agregado;
        }
        public void setNombre(string n)
        {
            this.nombre = n;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setParlamentario(Usuario p)
        {
            this.parlamentario = p;
        }
        public Usuario getParlamentario()
        {
            return parlamentario;
        }
        public void asignarAsesor(Usuario a)
        {
            
            for(int i=0; i < 8; i++)
            {
                if (asesores[i]!=null)
                {
                    asesores[i] = a;
                    agregado = 1;
                }
                
            }
        }
    }
}
