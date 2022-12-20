
namespace Frontend
{
    partial class FormularioCafé
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
            this.botonCerrarFormulario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idCafé = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreCafé = new System.Windows.Forms.TextBox();
            this.precioCafé = new System.Windows.Forms.TextBox();
            this.botonAgregarCafé = new System.Windows.Forms.Button();
            this.botonModificarCafé = new System.Windows.Forms.Button();
            this.botonEliminarCafé = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listaIdCafé = new System.Windows.Forms.ComboBox();
            this.botonLimpiarCampos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCerrarFormulario
            // 
            this.botonCerrarFormulario.Location = new System.Drawing.Point(649, 391);
            this.botonCerrarFormulario.Name = "botonCerrarFormulario";
            this.botonCerrarFormulario.Size = new System.Drawing.Size(118, 23);
            this.botonCerrarFormulario.TabIndex = 1;
            this.botonCerrarFormulario.Text = "Cerrar Formulario";
            this.botonCerrarFormulario.UseVisualStyleBackColor = true;
            this.botonCerrarFormulario.Click += new System.EventHandler(this.botonCaféCerrarFormulario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(218, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // idCafé
            // 
            this.idCafé.Location = new System.Drawing.Point(245, 72);
            this.idCafé.Name = "idCafé";
            this.idCafé.Size = new System.Drawing.Size(100, 20);
            this.idCafé.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(387, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(623, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // nombreCafé
            // 
            this.nombreCafé.Location = new System.Drawing.Point(461, 73);
            this.nombreCafé.Name = "nombreCafé";
            this.nombreCafé.Size = new System.Drawing.Size(120, 20);
            this.nombreCafé.TabIndex = 6;
            // 
            // precioCafé
            // 
            this.precioCafé.Location = new System.Drawing.Point(686, 76);
            this.precioCafé.Name = "precioCafé";
            this.precioCafé.Size = new System.Drawing.Size(81, 20);
            this.precioCafé.TabIndex = 7;
            // 
            // botonAgregarCafé
            // 
            this.botonAgregarCafé.Location = new System.Drawing.Point(151, 207);
            this.botonAgregarCafé.Name = "botonAgregarCafé";
            this.botonAgregarCafé.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarCafé.TabIndex = 8;
            this.botonAgregarCafé.Text = "Agregar";
            this.botonAgregarCafé.UseVisualStyleBackColor = true;
            this.botonAgregarCafé.Click += new System.EventHandler(this.botonAgregarCafé_Click);
            // 
            // botonModificarCafé
            // 
            this.botonModificarCafé.Location = new System.Drawing.Point(258, 207);
            this.botonModificarCafé.Name = "botonModificarCafé";
            this.botonModificarCafé.Size = new System.Drawing.Size(75, 23);
            this.botonModificarCafé.TabIndex = 9;
            this.botonModificarCafé.Text = "Modificar";
            this.botonModificarCafé.UseVisualStyleBackColor = true;
            this.botonModificarCafé.Click += new System.EventHandler(this.botonModificarCafé_Click);
            // 
            // botonEliminarCafé
            // 
            this.botonEliminarCafé.Location = new System.Drawing.Point(366, 207);
            this.botonEliminarCafé.Name = "botonEliminarCafé";
            this.botonEliminarCafé.Size = new System.Drawing.Size(75, 23);
            this.botonEliminarCafé.TabIndex = 10;
            this.botonEliminarCafé.Text = "Eliminar";
            this.botonEliminarCafé.UseVisualStyleBackColor = true;
            this.botonEliminarCafé.Click += new System.EventHandler(this.botonEliminarCafé_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // listaIdCafé
            // 
            this.listaIdCafé.FormattingEnabled = true;
            this.listaIdCafé.Location = new System.Drawing.Point(61, 72);
            this.listaIdCafé.Name = "listaIdCafé";
            this.listaIdCafé.Size = new System.Drawing.Size(106, 21);
            this.listaIdCafé.TabIndex = 12;
            this.listaIdCafé.SelectedIndexChanged += new System.EventHandler(this.listaIdCafé_SelectedIndexChanged);
            // 
            // botonLimpiarCampos
            // 
            this.botonLimpiarCampos.Location = new System.Drawing.Point(480, 207);
            this.botonLimpiarCampos.Name = "botonLimpiarCampos";
            this.botonLimpiarCampos.Size = new System.Drawing.Size(101, 23);
            this.botonLimpiarCampos.TabIndex = 13;
            this.botonLimpiarCampos.Text = "Limpiar Campos";
            this.botonLimpiarCampos.UseVisualStyleBackColor = true;
            this.botonLimpiarCampos.Click += new System.EventHandler(this.botonCaféLimpiarCampos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormularioCafé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonLimpiarCampos);
            this.Controls.Add(this.listaIdCafé);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonEliminarCafé);
            this.Controls.Add(this.botonModificarCafé);
            this.Controls.Add(this.botonAgregarCafé);
            this.Controls.Add(this.precioCafé);
            this.Controls.Add(this.nombreCafé);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCafé);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCerrarFormulario);
            this.Name = "FormularioCafé";
            this.Text = "FormularioCafé";
            this.Load += new System.EventHandler(this.FormularioCafé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonCerrarFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idCafé;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreCafé;
        private System.Windows.Forms.TextBox precioCafé;
        private System.Windows.Forms.Button botonAgregarCafé;
        private System.Windows.Forms.Button botonModificarCafé;
        private System.Windows.Forms.Button botonEliminarCafé;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listaIdCafé;
        private System.Windows.Forms.Button botonLimpiarCampos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}