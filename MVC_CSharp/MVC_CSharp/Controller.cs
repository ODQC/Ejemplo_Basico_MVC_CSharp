using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_CSharp
{
    class Controller
    {
        private View formulario; // se crea la vista en el controlador
        private Model model;// se crea el modelo en el controlador
        public Controller() { //Costructor
            formulario = new View();// Se instancia la vista
            model = new Model();// Se instancia el modelo
            this.CararEventos();
            model.MyProperty = "Hola"; // se carga un valor al campo del modelo
            Application.Run(formulario); // Muestra la vista 
           

        }
        void CararEventos()// funcion que crea los eventos de listener de cada elemento de la vista
        {
            formulario.button1.Click += new EventHandler(this.MostrarMensaje);// se asigna el elemento, el evento y su funcion respectiva a ese evento
        }
        
        void MostrarMensaje(Object sender,EventArgs e)//El evento que resive un elemento y el evento al que debe de reacionar
        {


            String mensaje = model.MyProperty.ToString();
            MessageBox.Show(mensaje);


        }
        void CargarTablero() { 

            
        }
       

    }
}
