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
    public partial class EstudianteForm : Form
    {
        ManagerEstudiantes manager = new ManagerEstudiantes();
        public EstudianteForm(ManagerEstudiantes manager)
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
            manager.AgregarEstudiante(nombre, apellido, ci, codigo);
            LimpiarCampos();
            ActualizarLista();
        }

        private void LimpiarCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void ActualizarLista()
        {
            listBox1.Items.Clear();
            foreach (Estudiante estudiante in manager.ListaEstudiante)
            {
                listBox1.Items.Add(estudiante);
            }
        }
    }
}
