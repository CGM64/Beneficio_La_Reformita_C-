
namespace Frontend
{
    partial class FormularioKardex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idCafé = new System.Windows.Forms.ComboBox();
            this.nombreCafé = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clienteProveedorCafé = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cantidadCafé = new System.Windows.Forms.TextBox();
            this.botonAgregarCafé = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.precioCafé = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaCafé = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreClienteProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idClienteProveedorCafé = new System.Windows.Forms.ComboBox();
            this.botonModificarCafé = new System.Windows.Forms.Button();
            this.botonCaféEliminar = new System.Windows.Forms.Button();
            this.botonLimpiarCampos = new System.Windows.Forms.Button();
            this.botonCerrarFormulario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idKardex = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listaKardex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(152, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Café";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(308, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // idCafé
            // 
            this.idCafé.FormattingEnabled = true;
            this.idCafé.Location = new System.Drawing.Point(98, 125);
            this.idCafé.Name = "idCafé";
            this.idCafé.Size = new System.Drawing.Size(170, 21);
            this.idCafé.TabIndex = 3;
            this.idCafé.SelectedIndexChanged += new System.EventHandler(this.idCafé_SelectedIndexChanged);
            // 
            // nombreCafé
            // 
            this.nombreCafé.Location = new System.Drawing.Point(293, 126);
            this.nombreCafé.Name = "nombreCafé";
            this.nombreCafé.Size = new System.Drawing.Size(103, 20);
            this.nombreCafé.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(161, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // clienteProveedorCafé
            // 
            this.clienteProveedorCafé.FormattingEnabled = true;
            this.clienteProveedorCafé.Location = new System.Drawing.Point(98, 175);
            this.clienteProveedorCafé.Name = "clienteProveedorCafé";
            this.clienteProveedorCafé.Size = new System.Drawing.Size(170, 21);
            this.clienteProveedorCafé.TabIndex = 6;
            this.clienteProveedorCafé.SelectedIndexChanged += new System.EventHandler(this.clienteProveedorCafé_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(455, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // cantidadCafé
            // 
            this.cantidadCafé.Location = new System.Drawing.Point(439, 125);
            this.cantidadCafé.Name = "cantidadCafé";
            this.cantidadCafé.Size = new System.Drawing.Size(100, 20);
            this.cantidadCafé.TabIndex = 8;
            // 
            // botonAgregarCafé
            // 
            this.botonAgregarCafé.Location = new System.Drawing.Point(147, 304);
            this.botonAgregarCafé.Name = "botonAgregarCafé";
            this.botonAgregarCafé.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarCafé.TabIndex = 9;
            this.botonAgregarCafé.Text = "Agregar";
            this.botonAgregarCafé.UseVisualStyleBackColor = true;
            this.botonAgregarCafé.Click += new System.EventHandler(this.botonAgregarCafé_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(590, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // precioCafé
            // 
            this.precioCafé.Location = new System.Drawing.Point(570, 125);
            this.precioCafé.Name = "precioCafé";
            this.precioCafé.Size = new System.Drawing.Size(100, 20);
            this.precioCafé.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(544, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha";
            // 
            // fechaCafé
            // 
            this.fechaCafé.CustomFormat = "dd-MM-yyyy";
            this.fechaCafé.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCafé.Location = new System.Drawing.Point(468, 234);
            this.fechaCafé.Name = "fechaCafé";
            this.fechaCafé.Size = new System.Drawing.Size(202, 20);
            this.fechaCafé.TabIndex = 13;
            this.fechaCafé.Value = new System.DateTime(2021, 10, 28, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(504, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cliente/Proveedor";
            // 
            // nombreClienteProveedor
            // 
            this.nombreClienteProveedor.Location = new System.Drawing.Point(468, 184);
            this.nombreClienteProveedor.Name = "nombreClienteProveedor";
            this.nombreClienteProveedor.Size = new System.Drawing.Size(202, 20);
            this.nombreClienteProveedor.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(103, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id Cliente/Proveedor";
            // 
            // idClienteProveedorCafé
            // 
            this.idClienteProveedorCafé.FormattingEnabled = true;
            this.idClienteProveedorCafé.Location = new System.Drawing.Point(92, 234);
            this.idClienteProveedorCafé.Name = "idClienteProveedorCafé";
            this.idClienteProveedorCafé.Size = new System.Drawing.Size(176, 21);
            this.idClienteProveedorCafé.TabIndex = 17;
            this.idClienteProveedorCafé.SelectedIndexChanged += new System.EventHandler(this.idClienteProveedorCafé_SelectedIndexChanged);
            // 
            // botonModificarCafé
            // 
            this.botonModificarCafé.Location = new System.Drawing.Point(254, 304);
            this.botonModificarCafé.Name = "botonModificarCafé";
            this.botonModificarCafé.Size = new System.Drawing.Size(75, 23);
            this.botonModificarCafé.TabIndex = 18;
            this.botonModificarCafé.Text = "Modificar";
            this.botonModificarCafé.UseVisualStyleBackColor = true;
            this.botonModificarCafé.Click += new System.EventHandler(this.botonModificarCafé_Click);
            // 
            // botonCaféEliminar
            // 
            this.botonCaféEliminar.Location = new System.Drawing.Point(378, 303);
            this.botonCaféEliminar.Name = "botonCaféEliminar";
            this.botonCaféEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonCaféEliminar.TabIndex = 19;
            this.botonCaféEliminar.Text = "Eliminar";
            this.botonCaféEliminar.UseVisualStyleBackColor = true;
            this.botonCaféEliminar.Click += new System.EventHandler(this.botonCaféEliminar_Click);
            // 
            // botonLimpiarCampos
            // 
            this.botonLimpiarCampos.Location = new System.Drawing.Point(490, 303);
            this.botonLimpiarCampos.Name = "botonLimpiarCampos";
            this.botonLimpiarCampos.Size = new System.Drawing.Size(90, 23);
            this.botonLimpiarCampos.TabIndex = 20;
            this.botonLimpiarCampos.Text = "Limpiar Campos";
            this.botonLimpiarCampos.UseVisualStyleBackColor = true;
            this.botonLimpiarCampos.Click += new System.EventHandler(this.botonCaféLimpiarCampos_Click);
            // 
            // botonCerrarFormulario
            // 
            this.botonCerrarFormulario.Location = new System.Drawing.Point(655, 394);
            this.botonCerrarFormulario.Name = "botonCerrarFormulario";
            this.botonCerrarFormulario.Size = new System.Drawing.Size(100, 23);
            this.botonCerrarFormulario.TabIndex = 21;
            this.botonCerrarFormulario.Text = "Cerrar Formulario";
            this.botonCerrarFormulario.UseVisualStyleBackColor = true;
            this.botonCerrarFormulario.Click += new System.EventHandler(this.botonCerrarFormulario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(103, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Id Entrada o Salida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(509, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Id Entrada o Salida";
            // 
            // idKardex
            // 
            this.idKardex.Location = new System.Drawing.Point(468, 68);
            this.idKardex.Name = "idKardex";
            this.idKardex.Size = new System.Drawing.Size(202, 20);
            this.idKardex.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listaKardex
            // 
            this.listaKardex.FormattingEnabled = true;
            this.listaKardex.Location = new System.Drawing.Point(105, 68);
            this.listaKardex.Name = "listaKardex";
            this.listaKardex.Size = new System.Drawing.Size(159, 21);
            this.listaKardex.TabIndex = 26;
            this.listaKardex.SelectedIndexChanged += new System.EventHandler(this.listaKardex_SelectedIndexChanged);
            // 
            // FormularioKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaKardex);
            this.Controls.Add(this.idKardex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.botonCerrarFormulario);
            this.Controls.Add(this.botonLimpiarCampos);
            this.Controls.Add(this.botonCaféEliminar);
            this.Controls.Add(this.botonModificarCafé);
            this.Controls.Add(this.idClienteProveedorCafé);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nombreClienteProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fechaCafé);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.precioCafé);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonAgregarCafé);
            this.Controls.Add(this.cantidadCafé);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clienteProveedorCafé);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreCafé);
            this.Controls.Add(this.idCafé);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormularioKardex";
            this.Text = "FormularioKardex";
            this.Load += new System.EventHandler(this.FormularioEntradaYSalidaDeCafé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idCafé;
        private System.Windows.Forms.TextBox nombreCafé;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clienteProveedorCafé;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cantidadCafé;
        private System.Windows.Forms.Button botonAgregarCafé;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precioCafé;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombreClienteProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox idClienteProveedorCafé;
        private System.Windows.Forms.Button botonModificarCafé;
        private System.Windows.Forms.Button botonCaféEliminar;
        private System.Windows.Forms.Button botonLimpiarCampos;
        private System.Windows.Forms.Button botonCerrarFormulario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idKardex;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker fechaCafé;
        private System.Windows.Forms.ComboBox listaKardex;
    }
}