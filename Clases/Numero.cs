using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Numero
    {
        public double numero;

        public Numero()
        {
            this.numero = 0;
        }
        //El constructor por defecto inicializa el atributo numero en 0

        public Numero(string num)
        {
            double.TryParse(num, out this.numero);
        }
        //Este constructor recibe un string como parametro
        //y lo convierte en un double 
        public Numero(double num)
        {
            this.numero = num;
        }
        //recibe un double como parametro y se lo asigna a numero

        private double validarNumero(string x)
        {
            //double num;
            double aux=0;

            //double.TryParse( x, out num);
            if (x != "0")
            {
                return aux = 1;
            }
            
            return aux;
        }
        //en este metodo el numero ingresado es pasado de string a double
        //se comprueba que sea distinto de 0 y se devuelve 0 si es distinto a la condicion
        //se devuelve 1 si lo es 

        private double getNumero()
        {
            return this.numero;
        }

        private void setNumero(string numx)
        {
            if (this.validarNumero(numx) != 0)
            {
                double.TryParse(numx, out this.numero);
            }

            
        }
        
    }
}
