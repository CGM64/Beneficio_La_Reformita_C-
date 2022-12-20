
namespace Frontend
{
    partial class FormularioUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.botonAgregarUsuario = new System.Windows.Forms.Button();
            this.botonModificarUsuario = new System.Windows.Forms.Button();
            this.botonEliminarUsuario = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contrasna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usuariosLista = new System.Windows.Forms.ComboBox();
            this.botonCerrarForuolario = new System.Windows.Forms.Button();
            this.botonLimpiarCampos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idUsuarios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(312, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // botonAgregarUsuario
            // 
            this.botonAgregarUsuario.Location = new System.Drawing.Point(187, 273);
            this.botonAgregarUsuario.Name = "botonAgregarUsuario";
            this.botonAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarUsuario.TabIndex = 1;
            this.botonAgregarUsuario.Text = "Agregar";
            this.botonAgregarUsuario.UseVisualStyleBackColor = true;
            this.botonAgregarUsuario.Click += new System.EventHandler(this.botonAgregarUsuario_Click);
            // 
            // botonModificarUsuario
            // 
            this.botonModificarUsuario.Location = new System.Drawing.Point(298, 273);
            this.botonModificarUsuario.Name = "botonModificarUsuario";
            this.botonModificarUsuario.Size = new System.Drawing.Size(75, 23);
            this.botonModificarUsuario.TabIndex = 2;
            this.botonModificarUsuario.Text = "Modificar";
            this.botonModificarUsuario.UseVisualStyleBackColor = true;
            this.botonModificarUsuario.Click += new System.EventHandler(this.botonModificarUsuario_Click);
            // 
            // botonEliminarUsuario
            // 
            this.botonEliminarUsuario.Location = new System.Drawing.Point(404, 273);
            this.botonEliminarUsuario.Name = "botonEliminarUsuario";
            this.botonEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.botonEliminarUsuario.TabIndex = 3;
            this.botonEliminarUsuario.Text = "Eliminar";
            this.botonEliminarUsuario.UseVisualStyleBackColor = true;
            this.botonEliminarUsuario.Click += new System.EventHandler(this.botonEliminarUsuario_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(351, 203);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(124, 20);
            this.usuario.TabIndex = 4;
            // 
            // contrasna
            // 
            this.contrasna.Location = new System.Drawing.Point(617, 204);
            this.contrasna.Name = "contrasna";
            this.contrasna.PasswordChar = '*';
            this.contrasna.Size = new System.Drawing.Size(124, 20);
            this.contrasna.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(268, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(516, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(272, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuarios";
            // 
            // usuariosLista
            // 
            this.usuariosLista.FormattingEnabled = true;
            this.usuariosLista.Location = new System.Drawing.Point(364, 121);
            this.usuariosLista.Name = "usuariosLista";
            this.usuariosLista.Size = new System.Drawing.Size(121, 21);
            this.usuariosLista.TabIndex = 9;
            this.usuariosLista.SelectedIndexChanged += new System.EventHandler(this.usuariosLista_SelectedIndexChanged);
            // 
            // botonCerrarForuolario
            // 
            this.botonCerrarForuolario.Location = new System.Drawing.Point(642, 393);
            this.botonCerrarForuolario.Name = "botonCerrarForuolario";
            this.botonCerrarForuolario.Size = new System.Drawing.Size(99, 23);
            this.botonCerrarForuolario.TabIndex = 10;
            this.botonCerrarForuolario.Text = "Cerrar Formulario";
            this.botonCerrarForuolario.UseVisualStyleBackColor = true;
            this.botonCerrarForuolario.Click += new System.EventHandler(this.botonCerrarForuolario_Click);
            // 
            // botonLimpiarCampos
            // 
            this.botonLimpiarCampos.Location = new System.Drawing.Point(508, 273);
            this.botonLimpiarCampos.Name = "botonLimpiarCampos";
            this.botonLimpiarCampos.Size = new System.Drawing.Size(90, 23);
            this.botonLimpiarCampos.TabIndex = 11;
            this.botonLimpiarCampos.Text = "Limpiar Campos";
            this.botonLimpiarCampos.UseVisualStyleBackColor = true;
            this.botonLimpiarCampos.Click += new System.EventHandler(this.botonLimpiarCampos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(65, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id";
            // 
            // idUsuarios
            // 
            this.idUsuarios.Location = new System.Drawing.Point(92, 202);
            this.idUsuarios.Name = "idUsuarios";
            this.idUsuarios.Size = new System.Drawing.Size(139, 20);
            this.idUsuarios.TabIndex = 13;
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idUsuarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonLimpiarCampos);
            this.Controls.Add(this.botonCerrarForuolario);
            this.Controls.Add(this.usuariosLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contrasna);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.botonEliminarUsuario);
            this.Controls.Add(this.botonModificarUsuario);
            this.Controls.Add(this.botonAgregarUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormularioUsuarios";
            this.Text = "FormularioUsuarios";
            this.Load += new System.EventHandler(this.FormularioUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAgregarUsuario;
        private System.Windows.Forms.Button botonModificarUsuario;
        private System.Windows.Forms.Button botonEliminarUsuario;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contrasna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox usuariosLista;
        private System.Windows.Forms.Button botonCerrarForuolario;
        private System.Windows.Forms.Button botonLimpiarCampos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idUsuarios;
    }
}