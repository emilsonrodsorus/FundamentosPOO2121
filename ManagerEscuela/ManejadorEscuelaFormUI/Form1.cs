using ManagerEscuela.Managers;
using ManejadorEscuelaFormUI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorEscuelaFormUI
{
    public partial class Form1 : Form
    {
        Escuela managerEscuela;
        EstudianteForm estFormulario;
        ProfesorForm profFormulario;
        public Form1()
        {
            InitializeComponent();
            managerEscuela = new Escuela();
            estFormulario = new EstudianteForm(managerEscuela.ManagerEst);
            profFormulario = new ProfesorForm(managerEscuela.ManagerProf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estFormulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profFormulario.Show();
        }
    }
}
