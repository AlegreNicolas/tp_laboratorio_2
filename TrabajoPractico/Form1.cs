using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class Form1 : Form
    {
        public Clases.Numero numero1;
        public Clases.Numero numero2;
        public string operacion;
        public double resultado;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            string num1 = this.txtNumero1.Text;   //se crea un atributo string llamado num1 al cual se le asigna el
                                                  //string del textbox ingresado
            numero1 = new Clases.Numero(num1);    //se inicializa el atributo numero1 pasandole como parametro el string 
                                                  //asignado a num1

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
             string num2 = this.txtNumero2.Text;    //se crea un atributo string llamado num2 al cual se le asigna el
                                                    //string del textbox ingresado
                                                    //se inicializa el atributo numero2 pasandole como parametro el string 
                                                    //asignado a num2
            numero2 = new Clases.Numero(num2);
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            operacion = this.cmbOperacion.Text;     //la variable operacion se le asiga el signo elegico en el combobox
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();             //codigo que limpia txtbox indicado
            txtNumero2.Clear();
            cmbOperacion.ResetText();       //codigo para limpiar combobox
            lblResultado.ResetText();       //codigo para limpiar label
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            resultado = Clases.Calculadora.operar(numero1, numero2, operacion);//uso la variable resultado para guardar
                                                                               //el double que me devuelve el metodo operar 
                                                                               
            MessageBox.Show(" " + resultado);           //muestra un mensaje con el resultado 

            this.lblResultado.Text = ("Resultado : " + resultado); //esta linea permite cambiar el label y 
                                                                   //agregarle el resultado final
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            //this.lblResultado.Text = ("Resultado : " + resultado);
            
        }
    }
}
