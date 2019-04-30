using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        Dato inicio; // DECLARA UN OBJETO EL CUAL UTILIZAREMOS DE REFERENCIA PARA CONOCER EL INICIO DE LA LISTA
        Dato ultimo; // DECLARA UN OBJETO EL CUAL UTILIZAREMOS DE REFERENCIA PARA CONOCER EL ULTIMO OBJETO DE LA LISTA
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Agregar(Dato nuevo)  // FUNCION PARA AGREGAR UN NUEVO DATO (OBJETO) A LA LISTA
        {
            if (inicio == null) // VERIFICAMOS QUE SI NO ES EL PRIMER DATO A GUARDAR, DE SER A SI GUARDAMOS EL NUEVO DATO COMO EL INICIO DE LISTA A SI COMO EL ULTIMO DATO DE LA LISTA QUE SE INGRESO
            {
                inicio = nuevo; // EL NUEVO OBJETO VA SER EL INICIO DE LA LISTA
                ultimo = nuevo; // EL NUEVO OBJETO TAMBIEN SERA EL ULTIMO YA QUE ES EL ULTIMO OBJETO INGRESADO
            }
            else               // YA QUE NO ES EL PRIMER DATO DE LA LISTA, GUARDAREMOS EL NUEVO DATO EN EL SIGUIENTE DEL ULTIMO DATO GUARDADO
            {
                ultimo.Siguente = nuevo; // AL ULTIMO DATO GUARDADO LE ALMACENAMOS EN SU SIGUIENTE EL NUEVO DATO.
                ultimo = nuevo;         // EL NUEVO DATO LO GUARDAMOS COMO EL ULTIMO QUE SE INGRESO.
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) // EVENTO PARA AGREGAR UN NUEVO OBJETO A LA LISTA
        {
            Dato elNuevo = new Dato(Convert.ToInt32(txtDato.Text)); // CONVERTIMOS EL VALOR OBTENIDO EN LA CAJA DE TEXTO A ENTERO Y CREAMOS UN OBJETO CON ESE VALOR
            Agregar(elNuevo);           // LLAMAMOS LA FUNCION AGREGAR MANDANDOLE EL OBJETO NUEVO CREADO
            txtDato.Clear();            // LIMPIAMOS LA CAJA DE TEXTO DONDE SE INGRESO EL DATO.
        }

        private void btnMostrar_Click(object sender, EventArgs e) // EVENTO PARA MOSTRAR EL CONTENIDO DE LA LISTA
        {
            Dato aux = inicio;         // GUARDAMOS EN UN NUEVO OBJETO EL OBJETO QUE SE GUARDO EN EL INICIO PARA HACER EL RECORRIDO DESDE EL INICIO 
            while (aux != null)        // EJECUTAMOS UN CICLO HASTA QUE EL ULTIMO ELEMENTO DE LA LISTA SEA NULO
            {
                txtResultados.Text += aux.ToString() + Environment.NewLine;   // MOSTRAMOS EN LA CAJA DE TEXTO EL CONTENDIO DE LA LISTA JUNTO CON UN SALTO DE LINEA
                aux = aux.Siguente;        // PASAMOS AL SIGUIENTE OBJETO DE LA LISTA ASIGNANDO EL OBJETO SIGUIENTE DEL OBJETO AUXILIAR AL AUXILIAR
            }
        }
    }
}
