using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Calculadora
    {

        public static double operar(Numero numero1, Numero numero2, string operador)//se recibe como parametro 2 objetos Numeros , 1 string
                                                                                    //y se devuelve un double
        {
            Numero aux=new Numero();                    //se crea una variable tipo Numero en el cual se va a guardar el double que se devuelve
            //if (validarOperador(operador) != "+")
           // {
                switch (operador)//el switch compara el operador recibido
                {
                    case "+":
                        aux.numero = numero1.numero + numero2.numero;

                        break;

                    case "-":
                        aux.numero = numero1.numero - numero2.numero;

                        break;

                    case "*":
                        aux.numero = numero1.numero * numero2.numero;
                        break;

                    case "/":
                        if (numero2.numero != 0)//si el segundo numero ingresado es 0 no se podra hacer la division
                        {
                            aux.numero = numero1.numero / numero2.numero;
                            break;
                        }
                        aux.numero = 0;

                        break;

                }

            //}
            return aux.numero;      //se devuelve un double 
        }

        public string validarOperador(string operador)  //metodo para validar el operador elegido el cual recibe un string como parametro 
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")//se pregunta si es igual a alguno de los operadores y si es alguno de ellos se valida el operador ingresado
             return "valido";

            return "+";//si no es valido el operador ingresado de devuelve +
        }



    }
}
