
namespace Frontend
{
    partial class AccesoManipulaciónUsuarios
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
            this.botonIngresar = new System.Windows.Forms.Button();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.botonCerrarFormulario = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la contraseña proporcionada por la empresa";
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(334, 263);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(75, 23);
            this.botonIngresar.TabIndex = 1;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(259, 197);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.Size = new System.Drawing.Size(243, 20);
            this.contrasena.TabIndex = 2;
            // 
            // botonCerrarFormulario
            // 
            this.botonCerrarFormulario.Location = new System.Drawing.Point(629, 387);
            this.botonCerrarFormulario.Name = "botonCerrarFormulario";
            this.botonCerrarFormulario.Size = new System.Drawing.Size(97, 23);
            this.botonCerrarFormulario.TabIndex = 3;
            this.botonCerrarFormulario.Text = "Cerrar Formulario";
            this.botonCerrarFormulario.UseVisualStyleBackColor = true;
            this.botonCerrarFormulario.Click += new System.EventHandler(this.botonCerrarFormulario_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AccesoManipulaciónUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCerrarFormulario);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.label1);
            this.Name = "AccesoManipulaciónUsuarios";
            this.Text = "AccesoManipulaciónUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Button botonCerrarFormulario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}