using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Metodo para cargar formulario 
        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            operaciones op = new operaciones();
        //Operaciones a realizar
            int sumaResultado = op.suma(num1, num2);
            int restaResultado = op.resta(num1, num2);
            int multiplicacionResultado = op.multiplicacion(num1, num2);
            double divisionResultado = op.division(num1, num2);

         // Mostrar resultados en una ventana, "$" para una expresion mas sencilla y de mejor entendimiento
            MessageBox.Show($"Suma: {sumaResultado}\nResta: {restaResultado}\nMultiplicación: {multiplicacionResultado}\nDivisión: {divisionResultado}");
        //Sentencias de control, manda a llamar al metodo para hacer comparaciones
            ControlSentences control = new ControlSentences();
            control.EjemploSentencias(num1, num2);
        }
    }
    //Clase con operaciones matematicas
    class operaciones
    {
        public int suma(int a, int b)
        {
            return a + b;
        }

        public int resta(int a, int b)
        {
            return a - b;
        }

        public int multiplicacion(int a, int b)
        {
            return a * b;
        }

        public double division(int a, int b)
        {
           
            
            return (double)a / b;
           
            
        }
    }
    //Clase con sentencias de control
    class ControlSentences
    {
        //metodo de comparacion
        public void EjemploSentencias(int a, int b)
        {
            if (a > b)
            {
                MessageBox.Show($"{a} es mayor que {b}");
            }
            else if (a < b)
            {
                MessageBox.Show($"{a} es menor que {b}");
            }
            else
            {
                MessageBox.Show($"{a} es igual a {b}");
            }

            // Verifica si ambos números son positivos o negativos
            if (a > 0 && b > 0)
            {
                MessageBox.Show("Ambos números son positivos.");
            }
            else if (a < 0 || b < 0)
            {
                MessageBox.Show("Al menos uno de los números es negativo.");
            }
        }
    }
}