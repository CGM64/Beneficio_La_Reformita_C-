
namespace Frontend
{
    partial class FormularioProveedores
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
            this.botonAgregarProveedores = new System.Windows.Forms.Button();
            this.celularProveedores = new System.Windows.Forms.TextBox();
            this.nitProveedores = new System.Windows.Forms.TextBox();
            this.nombreProveedores = new System.Windows.Forms.TextBox();
            this.dpiProveedores = new System.Windows.Forms.TextBox();
            this.idProveedores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaIdProveedores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.botonProveedoresModificar = new System.Windows.Forms.Button();
            this.botonProveedoresEliminar = new System.Windows.Forms.Button();
            this.botonProveedoresCerrarFormulario = new System.Windows.Forms.Button();
            this.botonProveedoresLimpiarCampos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAgregarProveedores
            // 
            this.botonAgregarProveedores.Location = new System.Drawing.Point(173, 268);
            this.botonAgregarProveedores.Name = "botonAgregarProveedores";
            this.botonAgregarProveedores.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarProveedores.TabIndex = 11;
            this.botonAgregarProveedores.Text = "Agregar";
            this.botonAgregarProveedores.UseVisualStyleBackColor = true;
            this.botonAgregarProveedores.Click += new System.EventHandler(this.botonAgregarProveedores_Click);
            // 
            // celularProveedores
            // 
            this.celularProveedores.Location = new System.Drawing.Point(652, 180);
            this.celularProveedores.Name = "celularProveedores";
            this.celularProveedores.Size = new System.Drawing.Size(136, 20);
            this.celularProveedores.TabIndex = 10;
            // 
            // nitProveedores
            // 
            this.nitProveedores.Location = new System.Drawing.Point(424, 180);
            this.nitProveedores.Name = "nitProveedores";
            this.nitProveedores.Size = new System.Drawing.Size(138, 20);
            this.nitProveedores.TabIndex = 9;
            // 
            // nombreProveedores
            // 
            this.nombreProveedores.Location = new System.Drawing.Point(98, 180);
            this.nombreProveedores.Name = "nombreProveedores";
            this.nombreProveedores.Size = new System.Drawing.Size(272, 20);
            this.nombreProveedores.TabIndex = 8;
            // 
            // dpiProveedores
            // 
            this.dpiProveedores.Location = new System.Drawing.Point(483, 116);
            this.dpiProveedores.Name = "dpiProveedores";
            this.dpiProveedores.Size = new System.Drawing.Size(151, 20);
            this.dpiProveedores.TabIndex = 7;
            // 
            // idProveedores
            // 
            this.idProveedores.Location = new System.Drawing.Point(315, 116);
            this.idProveedores.Name = "idProveedores";
            this.idProveedores.Size = new System.Drawing.Size(100, 20);
            this.idProveedores.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(141, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // listaIdProveedores
            // 
            this.listaIdProveedores.FormattingEnabled = true;
            this.listaIdProveedores.Location = new System.Drawing.Point(168, 116);
            this.listaIdProveedores.Name = "listaIdProveedores";
            this.listaIdProveedores.Size = new System.Drawing.Size(105, 21);
            this.listaIdProveedores.TabIndex = 13;
            this.listaIdProveedores.SelectedIndexChanged += new System.EventHandler(this.listaIdProveedores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(288, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(442, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "DPI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(24, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(384, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "NIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(580, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Celular";
            // 
            // botonProveedoresModificar
            // 
            this.botonProveedoresModificar.Location = new System.Drawing.Point(285, 267);
            this.botonProveedoresModificar.Name = "botonProveedoresModificar";
            this.botonProveedoresModificar.Size = new System.Drawing.Size(75, 23);
            this.botonProveedoresModificar.TabIndex = 19;
            this.botonProveedoresModificar.Text = "Modificar";
            this.botonProveedoresModificar.UseVisualStyleBackColor = true;
            this.botonProveedoresModificar.Click += new System.EventHandler(this.botonProveedoresModificar_Click);
            // 
            // botonProveedoresEliminar
            // 
            this.botonProveedoresEliminar.Location = new System.Drawing.Point(392, 268);
            this.botonProveedoresEliminar.Name = "botonProveedoresEliminar";
            this.botonProveedoresEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonProveedoresEliminar.TabIndex = 20;
            this.botonProveedoresEliminar.Text = "Eliminar";
            this.botonProveedoresEliminar.UseVisualStyleBackColor = true;
            this.botonProveedoresEliminar.Click += new System.EventHandler(this.botonProveedoresEliminar_Click);
            // 
            // botonProveedoresCerrarFormulario
            // 
            this.botonProveedoresCerrarFormulario.Location = new System.Drawing.Point(652, 401);
            this.botonProveedoresCerrarFormulario.Name = "botonProveedoresCerrarFormulario";
            this.botonProveedoresCerrarFormulario.Size = new System.Drawing.Size(100, 23);
            this.botonProveedoresCerrarFormulario.TabIndex = 21;
            this.botonProveedoresCerrarFormulario.Text = "Cerrar Formulario";
            this.botonProveedoresCerrarFormulario.UseVisualStyleBackColor = true;
            this.botonProveedoresCerrarFormulario.Click += new System.EventHandler(this.botonProveedoresCerrarFormulario_Click);
            // 
            // botonProveedoresLimpiarCampos
            // 
            this.botonProveedoresLimpiarCampos.Location = new System.Drawing.Point(503, 267);
            this.botonProveedoresLimpiarCampos.Name = "botonProveedoresLimpiarCampos";
            this.botonProveedoresLimpiarCampos.Size = new System.Drawing.Size(89, 23);
            this.botonProveedoresLimpiarCampos.TabIndex = 22;
            this.botonProveedoresLimpiarCampos.Text = "Limpiar Campos";
            this.botonProveedoresLimpiarCampos.UseVisualStyleBackColor = true;
            this.botonProveedoresLimpiarCampos.Click += new System.EventHandler(this.botonProveedoresLimpiarCampos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormularioProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonProveedoresLimpiarCampos);
            this.Controls.Add(this.botonProveedoresCerrarFormulario);
            this.Controls.Add(this.botonProveedoresEliminar);
            this.Controls.Add(this.botonProveedoresModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaIdProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonAgregarProveedores);
            this.Controls.Add(this.celularProveedores);
            this.Controls.Add(this.nitProveedores);
            this.Controls.Add(this.nombreProveedores);
            this.Controls.Add(this.dpiProveedores);
            this.Controls.Add(this.idProveedores);
            this.Name = "FormularioProveedores";
            this.Text = "FormularioProveedores";
            this.Load += new System.EventHandler(this.FormularioProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAgregarProveedores;
        private System.Windows.Forms.TextBox celularProveedores;
        private System.Windows.Forms.TextBox nitProveedores;
        private System.Windows.Forms.TextBox nombreProveedores;
        private System.Windows.Forms.TextBox dpiProveedores;
        private System.Windows.Forms.TextBox idProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaIdProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button botonProveedoresModificar;
        private System.Windows.Forms.Button botonProveedoresEliminar;
        private System.Windows.Forms.Button botonProveedoresCerrarFormulario;
        private System.Windows.Forms.Button botonProveedoresLimpiarCampos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}