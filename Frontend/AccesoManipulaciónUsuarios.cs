using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class AccesoManipulaciónUsuarios : Form
    {
        public AccesoManipulaciónUsuarios()
        {
            InitializeComponent();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            if(contrasena.Text == "")
            {
                errorProvider1.SetError(contrasena, "Ingrese la Contraseña");
            }
            else
            {
                if(contrasena.Text == "#La Reformita 123")
                {
                    errorProvider1.SetError(contrasena, "");

                    Form abrirUsuarios = new FormularioUsuarios();
                    abrirUsuarios.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña, incorrecta", "La reformita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void botonCerrarFormulario_Click(object sender, EventArgs e)
        {
            DialogResult preguntaParaSalir;

            preguntaParaSalir = MessageBox.Show("¿Desea cerrar el formulario?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (preguntaParaSalir == DialogResult.OK)
            {
                Form abrirLogin = new Login();
                abrirLogin.Show();

                this.Dispose();
            }
        }
    }
}
