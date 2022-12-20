using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Backend;
using DataAccess;

namespace Frontend
{
    public partial class FormularioKardex : Form
    {
        KardexDAL kardex;
        ExistenciasDAL existencias;
        ReporteDeVentasDAL reporteDeVentas;
        FacturaciónClientesDAL facturacionClientesDAL;

        public FormularioKardex()
        {
            InitializeComponent();

            kardex = new KardexDAL();
            existencias = new ExistenciasDAL();
            reporteDeVentas = new ReporteDeVentasDAL();
            facturacionClientesDAL = new FacturaciónClientesDAL();
        }

        string conexionBaseDeDatos = ConfigurationManager.ConnectionStrings["BaseDeDatos"].ConnectionString;
        float recibirExistencia = 0, sumaRestaExistencia = 0, cantidadEncontradaKardex = 0;
        string recibirDpi, recibirNombre, recibirNit;
        long recibirCelular;

        private bool validarCamposVacíos()
        {
            bool validar = true;

            if (idKardex.Text == "" && idCafé.Text == "" && nombreCafé.Text == "" && precioCafé.Text == "" && clienteProveedorCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "Ingrese el Id del Café");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre del Café");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de Café");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio del Café");
                errorProvider1.SetError(clienteProveedorCafé, "Ingrese el Tipo");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idKardex.Text == "" && idCafé.Text == "" && nombreCafé.Text == "" && cantidadCafé.Text == "" && precioCafé.Text == "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "Ingrese el Id del Café");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre del Café");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de Café");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio del Café");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            else if (idKardex.Text == "" && clienteProveedorCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "Ingrese el Tipo");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (clienteProveedorCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "" && idCafé.Text == "" && nombreCafé.Text == "" && cantidadCafé.Text == "" && precioCafé.Text == "" && idKardex.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "Ingrese el Id del Café");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre del Café");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de Café");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio del Café");
                errorProvider1.SetError(clienteProveedorCafé, "Ingrese el Tipo");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            //
            else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "Ingrese el Tipo");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idKardex.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && idCafé.Text == "" && nombreCafé.Text == "" && cantidadCafé.Text == "" && precioCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "Ingrese el Id del Café");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre del Café");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de Café");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio del Café");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            else if (clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && idKardex.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            //
            //
            else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && cantidadCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de café");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idKardex.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && idCafé.Text == "" && nombreCafé.Text == "" && cantidadCafé.Text == "" && precioCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "Ingrese el Id del Café");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre del Café");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de Café");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio del Café");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            else if (clienteProveedorCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "" && idCafé.Text != "" && nombreCafé.Text == "" && cantidadCafé.Text == "" && precioCafé.Text == "" && idKardex.Text != "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "Ingrese el Id del Café");
                errorProvider1.SetError(nombreCafé, "Ingrese el Nombre del Café");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de Café");
                errorProvider1.SetError(precioCafé, "Ingrese el Precio del Café");
                errorProvider1.SetError(clienteProveedorCafé, "Ingrese el Tipo");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            //
            //
            else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && cantidadCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de café");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "" && cantidadCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de café");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && idKardex.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            else if (idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idClienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && idKardex.Text == "" && cantidadCafé.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de café");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
            //
            else if (idKardex.Text != "" && nombreCafé.Text != "" && idCafé.Text != "" && precioCafé.Text != "" && cantidadCafé.Text == "" && clienteProveedorCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de café");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "Ingrese el Tipo");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "" && idKardex.Text == "" && cantidadCafé.Text == "" && clienteProveedorCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de café");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "Ingrese el Tipo");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idCafé.Text != "" && nombreCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idKardex.Text == "" && cantidadCafé.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "Ingrese la Cantidad de café");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            else if (idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && idKardex.Text == "" && idClienteProveedorCafé.Text == "" && nombreClienteProveedor.Text == "")
            {
                validar = false;

                errorProvider1.SetError(idKardex, "Ingrese el Id de la Entrada o Salida");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "Ingrese el Id del Cliente o Proveedor");
                errorProvider1.SetError(nombreClienteProveedor, "Ingrese el Nombre del Cliente o Proveedor");
            }
            return validar;
        }

        private void borrarMensajeDeError()
        {
            if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "")
            {
                errorProvider1.SetError(idKardex, "");
                errorProvider1.SetError(idCafé, "");
                errorProvider1.SetError(nombreCafé, "");
                errorProvider1.SetError(cantidadCafé, "");
                errorProvider1.SetError(precioCafé, "");
                errorProvider1.SetError(clienteProveedorCafé, "");
                errorProvider1.SetError(idClienteProveedorCafé, "");
                errorProvider1.SetError(nombreClienteProveedor, "");
            }
        }

        private void botonAgregarCafé_Click(object sender, EventArgs e)
        {
            if (idKardex.Text == "" || idCafé.Text == "" || nombreCafé.Text == "" || cantidadCafé.Text == "" || precioCafé.Text == "" || clienteProveedorCafé.Text == "" || nombreClienteProveedor.Text == "")
            {
                validarCamposVacíos();
            } else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "")
            {
                if (clienteProveedorCafé.Text == "Cliente")
                {
                    manipularExistencias();

                    if (recibirExistencia >= float.Parse(cantidadCafé.Text) && recibirExistencia > 0)
                    {
                        borrarMensajeDeError();

                        decimal total = 0;

                        kardex.Insertar(
                            new Kardex(
                                idKardex.Text,
                                float.Parse(cantidadCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                clienteProveedorCafé.Text,
                                idClienteProveedorCafé.Text,
                                nombreClienteProveedor.Text,
                                DateTime.Parse(fechaCafé.Text),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                            )
                        );

                        listadoKardex();

                        decimal totalQuetzales = 0;

                        sumaRestaExistencia = recibirExistencia - float.Parse(cantidadCafé.Text);

                        existencias.Modificar(
                            new Existencias(
                                sumaRestaExistencia,
                                totalQuetzales = (decimal.Parse(precioCafé.Text) * decimal.Parse(sumaRestaExistencia.ToString())),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                            )
                        );

                        manipularExistencias();

                        reporteDeVentas.Insertar(
                            new ReporteDeVentas(
                                idKardex.Text,
                                float.Parse(cantidadCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                idClienteProveedorCafé.Text,
                                nombreClienteProveedor.Text,
                                DateTime.Parse(fechaCafé.Text),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                           )
                        );

                        facturacionClientesDAL.Insertar(
                            new FacturaciónClientes(
                                idKardex.Text,
                                nombreCafé.Text,
                                float.Parse(cantidadCafé.Text),
                                decimal.Parse(precioCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                DateTime.Parse(fechaCafé.Text),
                                recibirDpi,
                                recibirNombre,
                                recibirNit, 
                                recibirCelular
                            )
                        );
                    }
                    else if (recibirExistencia < float.Parse(cantidadCafé.Text))
                    {
                        MessageBox.Show("Error al agregar la Salida, cantidad de quintales insuficientes.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        MessageBox.Show("Quintales disponibles: " + recibirExistencia, "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        errorProvider1.SetError(cantidadCafé, "Ingrese una cantidad menor o igual a la cantidad de la base de datos");
                    } 
                } else if (clienteProveedorCafé.Text == "Proveedor")
                {
                    borrarMensajeDeError();
                    manipularExistencias();

                    decimal total = 0;

                    kardex.Insertar(
                        new Kardex(
                            idKardex.Text,
                            float.Parse(cantidadCafé.Text),
                            total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                            clienteProveedorCafé.Text,
                            idClienteProveedorCafé.Text,
                            nombreClienteProveedor.Text,
                            DateTime.Parse(fechaCafé.Text),
                            idCafé.Text,
                            nombreCafé.Text,
                            decimal.Parse(precioCafé.Text)
                        )
                    );

                    listadoKardex();

                    decimal totalQuetzales = 0;

                    sumaRestaExistencia = recibirExistencia + float.Parse(cantidadCafé.Text);

                    existencias.Modificar(
                        new Existencias(
                            sumaRestaExistencia,
                            totalQuetzales = (decimal.Parse(precioCafé.Text) * decimal.Parse(sumaRestaExistencia.ToString())),
                            idCafé.Text,
                            nombreCafé.Text,
                            decimal.Parse(precioCafé.Text)
                        )
                    );

                    manipularExistencias();
                }
            }
        }

        private void manipularExistencias()
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Existencia From Existencias Where Id = '{idCafé.Text}'";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        recibirExistencia = float.Parse(encontrarValores["Existencia"].ToString());
                    }
                }
            }
        }

        private void FormularioEntradaYSalidaDeCafé_Load(object sender, EventArgs e)
        {
            clienteProveedorCafé.Items.Add("Cliente");
            clienteProveedorCafé.Items.Add("Proveedor");

            listadoKardex();
            listaCafé();
            manipularExistencias();
        }

        private void idCafé_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Nombre, Precio From Café Where Id = '{idCafé.Text}'";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        nombreCafé.Text = encontrarValores["Nombre"].ToString();
                        precioCafé.Text = encontrarValores["Precio"].ToString();
                    }
                }
            }
        }

        private void listadoKardex()
        {
            listaKardex.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id From Kardex";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        listaKardex.Items.Add(encontrarValores["Id"].ToString());
                    }

                    conexion.Close();
                }
            }
        }

        private void listaCafé()
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id From Café";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idCafé.Items.Add(encontrarValores["Id"].ToString());
                    }

                    conexion.Close();
                }
            }
        }

        private void clienteProveedorCafé_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clienteProveedorCafé.Text == "Cliente")
            {
                listaClientes();
                manipularExistencias();
            }
            else if (clienteProveedorCafé.Text == "Proveedor")
            {
                listaProveedores();
                manipularExistencias();
            }
        }

        private void listaClientes()
        {
            idClienteProveedorCafé.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id From Clientes";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idClienteProveedorCafé.Items.Add(encontrarValores["Id"].ToString());
                    }

                    conexion.Close();
                }
            }
        }

        private void listaProveedores()
        {
            idClienteProveedorCafé.Items.Clear();

            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id From Proveedores";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idClienteProveedorCafé.Items.Add(encontrarValores["Id"].ToString());
                    }

                    conexion.Close();
                }
            }
        }

        private void idClienteProveedorCafé_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comprueba, si es cliente o proveedor y muestra los datos en el combo box correspondiente
            if (clienteProveedorCafé.Text == "Cliente")
            {
                using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
                {
                    conexion.Open();

                    string lista = $"Select * From Clientes Where Id = '{idClienteProveedorCafé.Text}'";

                    using (SqlCommand comando = new SqlCommand(lista, conexion))
                    {
                        comando.ExecuteNonQuery();

                        SqlDataReader encontrarValores = comando.ExecuteReader();

                        while (encontrarValores.Read() == true)
                        {
                            nombreClienteProveedor.Text = encontrarValores["Nombre"].ToString();
                            recibirDpi = encontrarValores["DPI"].ToString();
                            recibirNombre = encontrarValores["Nombre"].ToString();
                            recibirNit = encontrarValores["NIT"].ToString();
                            recibirCelular = long.Parse(encontrarValores["Celular"].ToString());
                        }
                    }
                }
            }
            else if (clienteProveedorCafé.Text == "Proveedor")
            {
                using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
                {
                    conexion.Open();

                    string lista = $"Select Nombre From Proveedores Where Id = '{idClienteProveedorCafé.Text}'";

                    using (SqlCommand comando = new SqlCommand(lista, conexion))
                    {
                        comando.ExecuteNonQuery();

                        SqlDataReader encontrarValores = comando.ExecuteReader();

                        while (encontrarValores.Read() == true)
                        {
                            nombreClienteProveedor.Text = encontrarValores["Nombre"].ToString();
                        }
                    }
                }
            }
        }

        private void botonCaféLimpiarCampos_Click(object sender, EventArgs e)
        {
            DialogResult preguntaLimpiarCampos;

            preguntaLimpiarCampos = MessageBox.Show("¿Desea limpiar todos los campos?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (preguntaLimpiarCampos == DialogResult.OK)
            {
                idKardex.Clear();
                nombreCafé.Clear();
                cantidadCafé.Clear();
                precioCafé.Clear();
                nombreClienteProveedor.Clear();

                MessageBox.Show("Campos limpios.", "La Reformita");
            }
        }

        private void botonModificarCafé_Click(object sender, EventArgs e)
        {
            DialogResult preguntaModificar;

            preguntaModificar = MessageBox.Show("¿Desea modificar los datos de esta Entrada o Salida?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaModificar == DialogResult.Yes)
            {
                if (idKardex.Text == "" || idCafé.Text == "" || nombreCafé.Text == "" || cantidadCafé.Text == "" || precioCafé.Text == "" || clienteProveedorCafé.Text == "" || nombreClienteProveedor.Text == "" || fechaCafé.Text == "")
                {
                    validarCamposVacíos();
                }
                else if (idKardex.Text != "" && idCafé.Text != "" && nombreCafé.Text != "" && cantidadCafé.Text != "" && precioCafé.Text != "" && clienteProveedorCafé.Text != "" && nombreClienteProveedor.Text != "" && fechaCafé.Text != "")
                {
                    if (recibirExistencia > float.Parse(cantidadCafé.Text))
                    {
                        borrarMensajeDeError();
                        manipularExistencias();

                        decimal total = 0;

                        kardex.Modificar(
                            new Kardex(
                                idKardex.Text,
                                float.Parse(cantidadCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                clienteProveedorCafé.Text,
                                idClienteProveedorCafé.Text,
                                nombreClienteProveedor.Text,
                                DateTime.Parse(fechaCafé.Text),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                             )
                        );

                        listadoKardex();

                        decimal totalQuetzales = 0;

                        sumaRestaExistencia = recibirExistencia - (recibirExistencia - float.Parse(cantidadCafé.Text));

                        existencias.Modificar(
                            new Existencias(
                                sumaRestaExistencia,
                                totalQuetzales = (decimal.Parse(precioCafé.Text) * decimal.Parse(sumaRestaExistencia.ToString())),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                            )
                         );

                        manipularExistencias();

                        if (clienteProveedorCafé.Text == "Cliente")
                        {
                            reporteDeVentas.Modificar(
                                new ReporteDeVentas(
                                    idKardex.Text,
                                    float.Parse(cantidadCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    idClienteProveedorCafé.Text,
                                    nombreClienteProveedor.Text,
                                    DateTime.Parse(fechaCafé.Text),
                                    idCafé.Text,
                                    nombreCafé.Text,
                                    decimal.Parse(precioCafé.Text)
                               )
                            );

                            facturacionClientesDAL.Modificar(
                                new FacturaciónClientes(
                                    idKardex.Text,
                                    nombreCafé.Text,
                                    float.Parse(cantidadCafé.Text),
                                    decimal.Parse(precioCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    DateTime.Parse(fechaCafé.Text),
                                    recibirDpi,
                                    recibirNombre,
                                    recibirNit,
                                    recibirCelular
                                )
                            );
                        }
                    }
                    else if (recibirExistencia < float.Parse(cantidadCafé.Text) && recibirExistencia >= 0)
                    {
                        borrarMensajeDeError();
                        manipularExistencias();

                        decimal total = 0;

                        kardex.Modificar(
                            new Kardex(
                                idKardex.Text,
                                float.Parse(cantidadCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                clienteProveedorCafé.Text,
                                idClienteProveedorCafé.Text,
                                nombreClienteProveedor.Text,
                                DateTime.Parse(fechaCafé.Text),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                             )
                        );

                        listadoKardex();

                        decimal totalQuetzales = 0;

                        sumaRestaExistencia = recibirExistencia + (float.Parse(cantidadCafé.Text) - recibirExistencia);

                        existencias.Modificar(
                            new Existencias(
                                sumaRestaExistencia,
                                totalQuetzales = (decimal.Parse(precioCafé.Text) * decimal.Parse(sumaRestaExistencia.ToString())),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                            )
                         );

                        manipularExistencias();

                        if (clienteProveedorCafé.Text == "Cliente")
                        {
                            reporteDeVentas.Modificar(
                                new ReporteDeVentas(
                                    idKardex.Text,
                                    float.Parse(cantidadCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    idClienteProveedorCafé.Text,
                                    nombreClienteProveedor.Text,
                                    DateTime.Parse(fechaCafé.Text),
                                    idCafé.Text,
                                    nombreCafé.Text,
                                    decimal.Parse(precioCafé.Text)
                               )
                            );

                            facturacionClientesDAL.Modificar(
                                new FacturaciónClientes(
                                    idKardex.Text,
                                    nombreCafé.Text,
                                    float.Parse(cantidadCafé.Text),
                                    decimal.Parse(precioCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    DateTime.Parse(fechaCafé.Text),
                                    recibirDpi,
                                    recibirNombre,
                                    recibirNit,
                                    recibirCelular
                                )
                            );
                        }
                    }
                    else if (recibirExistencia == float.Parse(cantidadCafé.Text))
                    {
                        borrarMensajeDeError();
                        manipularExistencias();

                        decimal total = 0;

                        kardex.Modificar(
                            new Kardex(
                                idKardex.Text,
                                float.Parse(cantidadCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                clienteProveedorCafé.Text,
                                idClienteProveedorCafé.Text,
                                nombreClienteProveedor.Text,
                                DateTime.Parse(fechaCafé.Text),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                             )
                        );

                        listadoKardex();

                        decimal totalQuetzales = 0;

                        existencias.Modificar(
                            new Existencias(
                                float.Parse(cantidadCafé.Text),
                                totalQuetzales = (decimal.Parse(precioCafé.Text) * decimal.Parse(sumaRestaExistencia.ToString())),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                            )
                         );

                        manipularExistencias();

                        if (clienteProveedorCafé.Text == "Cliente")
                        {
                            reporteDeVentas.Modificar(
                                new ReporteDeVentas(
                                    idKardex.Text,
                                    float.Parse(cantidadCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    idClienteProveedorCafé.Text,
                                    nombreClienteProveedor.Text,
                                    DateTime.Parse(fechaCafé.Text),
                                    idCafé.Text,
                                    nombreCafé.Text,
                                    decimal.Parse(precioCafé.Text)
                               )
                            );

                            facturacionClientesDAL.Modificar(
                                new FacturaciónClientes(
                                    idKardex.Text,
                                    nombreCafé.Text,
                                    float.Parse(cantidadCafé.Text),
                                    decimal.Parse(precioCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    DateTime.Parse(fechaCafé.Text),
                                    recibirDpi,
                                    recibirNombre,
                                    recibirNit,
                                    recibirCelular
                                )
                            );
                        }
                    }
                    else if (recibirExistencia == 0)
                    {
                        MessageBox.Show("Error al modificar la Salida o Entrada, cantidad de quintales insuficientes.", "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        MessageBox.Show("Quintales disponibles: " + recibirExistencia, "La Reformita", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        errorProvider1.SetError(cantidadCafé, "Ingrese una cantidad menor o igual a la cantidad de la base de datos");
                    }
                }
            }
        }

        private void botonCerrarFormulario_Click(object sender, EventArgs e)
        {
            DialogResult preguntaLimpiarCampos;

            preguntaLimpiarCampos = MessageBox.Show("¿Desea cerrar el formulario?", "La Reformita", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (preguntaLimpiarCampos == DialogResult.OK)
            {
                Form abrirMenuPrincipal = new MenúPrincipal();
                abrirMenuPrincipal.Show();

                this.Dispose();
            }
        }

        private void botonCaféEliminar_Click(object sender, EventArgs e)
        {
            DialogResult preguntaModificar;

            preguntaModificar = MessageBox.Show("¿Desea eliminar los datos de esta Entrada o Salida?", "La Reformita", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (preguntaModificar == DialogResult.Yes)
            {
                if (listaKardex.Text == "" && idKardex.Text == "")
                {
                    validarCamposVacíos();
                }
                else if (listaKardex.Text != "" && idKardex.Text != "")
                {
                    if (clienteProveedorCafé.Text == "Cliente")
                    {
                        borrarMensajeDeError();
                        manipularExistencias();

                        decimal total = 0;

                        kardex.Eliminar(
                            new Kardex(
                                idKardex.Text,
                                float.Parse(cantidadCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                clienteProveedorCafé.Text,
                                idClienteProveedorCafé.Text,
                                nombreClienteProveedor.Text,
                                DateTime.Parse(fechaCafé.Text),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                             )
                        );

                        listadoKardex();

                        decimal totalQuetzales = 0;

                        sumaRestaExistencia = cantidadEncontradaKardex + float.Parse(cantidadCafé.Text);

                        existencias.Modificar(
                            new Existencias(
                                sumaRestaExistencia,
                                totalQuetzales = (decimal.Parse(precioCafé.Text) * decimal.Parse(sumaRestaExistencia.ToString())),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                            )
                        );

                        manipularExistencias();

                        reporteDeVentas.Eliminar(
                                new ReporteDeVentas(
                                    idKardex.Text,
                                    float.Parse(cantidadCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    idClienteProveedorCafé.Text,
                                    nombreClienteProveedor.Text,
                                    DateTime.Parse(fechaCafé.Text),
                                    idCafé.Text,
                                    nombreCafé.Text,
                                    decimal.Parse(precioCafé.Text)
                               )
                            );

                        facturacionClientesDAL.Eliminar(
                                new FacturaciónClientes(
                                    idKardex.Text,
                                    nombreCafé.Text,
                                    float.Parse(cantidadCafé.Text),
                                    decimal.Parse(precioCafé.Text),
                                    total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                    DateTime.Parse(fechaCafé.Text),
                                    recibirDpi,
                                    recibirNombre,
                                    recibirNit,
                                    recibirCelular
                                )
                            );
                    }
                    else if (clienteProveedorCafé.Text == "Proveedor")
                    {
                        borrarMensajeDeError();
                        manipularExistencias();

                        decimal total = 0;

                        kardex.Eliminar(
                            new Kardex(
                                idKardex.Text,
                                float.Parse(cantidadCafé.Text),
                                total = (decimal.Parse(cantidadCafé.Text) * decimal.Parse(precioCafé.Text)),
                                clienteProveedorCafé.Text,
                                idClienteProveedorCafé.Text,
                                nombreClienteProveedor.Text,
                                DateTime.Parse(fechaCafé.Text),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                             )
                        );

                        listadoKardex();

                        decimal totalQuetzales = 0;

                        sumaRestaExistencia = cantidadEncontradaKardex - float.Parse(cantidadCafé.Text);

                        existencias.Modificar(
                            new Existencias(
                                sumaRestaExistencia,
                                totalQuetzales = (decimal.Parse(precioCafé.Text) * decimal.Parse(sumaRestaExistencia.ToString())),
                                idCafé.Text,
                                nombreCafé.Text,
                                decimal.Parse(precioCafé.Text)
                            )
                        );

                        manipularExistencias();
                    }
                }
            }
        }

        private void listaKardex_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(conexionBaseDeDatos))
            {
                conexion.Open();

                string lista = $"Select Id, Id_Café, Nombre, Cantidad, Precio, Tipo, Id_Cliente_Proveedor, Cliente_Proveedor, Fecha From Kardex Where Id = '{listaKardex.Text}'";

                using (SqlCommand comando = new SqlCommand(lista, conexion))
                {
                    comando.ExecuteNonQuery();

                    SqlDataReader encontrarValores = comando.ExecuteReader();

                    while (encontrarValores.Read() == true)
                    {
                        idKardex.Text = encontrarValores["Id"].ToString();
                        idCafé.Text = encontrarValores["Id_Café"].ToString();
                        nombreCafé.Text = encontrarValores["Nombre"].ToString();
                        cantidadCafé.Text = encontrarValores["Cantidad"].ToString();
                        cantidadEncontradaKardex = float.Parse(encontrarValores["Cantidad"].ToString());
                        precioCafé.Text = encontrarValores["Precio"].ToString();
                        clienteProveedorCafé.Text = encontrarValores["Tipo"].ToString();
                        idClienteProveedorCafé.Text = encontrarValores["Id_Cliente_Proveedor"].ToString();
                        nombreClienteProveedor.Text = encontrarValores["Cliente_Proveedor"].ToString();
                        fechaCafé.Text = encontrarValores["Fecha"].ToString();
                    }
                }
            }
        }
    }
}
