using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using DataAccess;

namespace Frontend
{
    public partial class MenúPrincipal : Form
    {
        public MenúPrincipal()
        {
            InitializeComponent();
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            Form abrirClientes = new FormularioClientes();
            abrirClientes.Show();

            //Cierra el formulario
            this.Dispose();
        }

        private void botonProveedores_Click(object sender, EventArgs e)
        {
            Form abrirProveedores = new FormularioProveedores();
            abrirProveedores.Show();

            //Cierra el formulario
            this.Dispose();
        }

        private void botonCafé_Click(object sender, EventArgs e)
        {
            Form abrirCafé = new FormularioCafé();
            abrirCafé.Show();

            //Cierra el formulario
            this.Dispose();
        }

        private void botonMenúPrincipalCerrarSesión_Click(object sender, EventArgs e)
        {
            DialogResult salirFormulario;
            salirFormulario = MessageBox.Show("¿Desea cerrar sesión?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(salirFormulario == DialogResult.OK)
            {
                Form cerrarSesion = new Login();
                cerrarSesion.Show();

                this.Dispose();
            }
        }

        private void botonEntradaYsalidaDeCafé_Click(object sender, EventArgs e)
        {
            Form abrirFormulario = new FormularioKardex();
            abrirFormulario.Show();

            this.Dispose();
        }

        private void botonVerFacturacionClientes_Click(object sender, EventArgs e)
        {
            Form abrirFormulario = new VerFacturaciónClientes();
            abrirFormulario.Show();

            this.Dispose();
        }

        private void botonVerExistencias_Click(object sender, EventArgs e)
        {
            Form abrirFormulario = new VerExistencias();
            abrirFormulario.Show();

            this.Dispose();
        }

        private void botonVerKardex_Click(object sender, EventArgs e)
        {
            Form abrirFormulario = new VerKardex();
            abrirFormulario.Show();

            this.Dispose();
        }

        private void botonVerInformeDeVentas_Click(object sender, EventArgs e)
        {
            Form abrirFormulario = new InformeDeVentas();
            abrirFormulario.Show();

            this.Dispose();
        }
    }
}
