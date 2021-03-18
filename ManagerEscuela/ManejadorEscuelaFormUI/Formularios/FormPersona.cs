using ManagerEscuela.Filters;
using ManagerEscuela.Interface;
using ManagerEscuela.Managers;
using ManagerEscuela.Models.PadreModels;
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
    public partial class FormPersona : Form
    {
        ManagerPersonas manager;
        ManagerFiltros filtros;
        public FormPersona(ManagerPersonas manager, ManagerFiltros filtros)
        {
            InitializeComponent();
            this.manager = manager;
            this.filtros = filtros;
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string ci = textBox3.Text;
            int codigo = Convert.ToInt32(textBox4.Text);
            manager.AgregarEstudiante(nombre,apellido,ci, codigo);
            LimpiarCampos();
            ActualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string ci = textBox3.Text;
            int codigo = Convert.ToInt32(textBox4.Text);
            manager.AgregarAdministrativoPlanta(nombre, apellido, ci, codigo);
            LimpiarCampos();
            ActualizarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string ci = textBox3.Text;
            int codigo = Convert.ToInt32(textBox4.Text);
            manager.AgregarAdministrativoConsultor(nombre, apellido, ci, codigo);
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
            foreach (Persona persona in manager.ListaPersona)
            {
                listBox1.Items.Add(persona);
            }
        }

        private void CargarDatos()
        {
            comboBox2.Items.Add("Estudiante");
            comboBox2.Items.Add("Profesor");
            comboBox2.Items.Add("Planta");
            comboBox2.Items.Add("Consultor");

            comboBox1.Items.Add(new FilterByType());
            comboBox1.Items.Add(new FilterByName());
        }

        private void FiltrarPor(object sender, EventArgs e)
        {
            object objectSelected = comboBox1.SelectedItem;
            string parameter = objectSelected is FilterByName ? textBox6.Text : comboBox2.Text;
            listBox1.Items.Clear();
            foreach (Persona persona in filtros.Filtrar(manager.ListaPersona,
                parameter, (IFilter)objectSelected))
            {
                listBox1.Items.Add(persona);
            }
        }
    }
}
