using ManagerEscuela.Managers;
using ManagerEscuela.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorEscuelaFormUI.Formularios
{
    public partial class ProfesorForm : Form
    {

        ManagerProfesores manager = new ManagerProfesores();

        public ProfesorForm(ManagerProfesores manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string ci = textBox3.Text;
            int codigo = Convert.ToInt32(textBox4.Text);
            string materia = textBox5.Text;
            manager.AgregarProfesor(nombre, apellido, ci, codigo, materia);
            LimpiarCampos();
            ActualizarLista();
        }

        private void LimpiarCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void ActualizarLista()
        {
            listBox1.Items.Clear();
            foreach (Profesor estudiante in manager.ListaProfesor)
            {
                listBox1.Items.Add(estudiante);
            }
        }
    }
}
