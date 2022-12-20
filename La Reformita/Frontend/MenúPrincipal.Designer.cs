
namespace Frontend
{
    partial class MenúPrincipal
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
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonProveedores = new System.Windows.Forms.Button();
            this.botonCafé = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCerrarSesión = new System.Windows.Forms.Button();
            this.botonEntradaYsalidaDeCafé = new System.Windows.Forms.Button();
            this.botonVerKardex = new System.Windows.Forms.Button();
            this.botonVerFacturacionClientes = new System.Windows.Forms.Button();
            this.botonVerInformeDeVentas = new System.Windows.Forms.Button();
            this.botonVerExistencias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonClientes
            // 
            this.botonClientes.Location = new System.Drawing.Point(80, 156);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(75, 23);
            this.botonClientes.TabIndex = 0;
            this.botonClientes.Text = "Clientes";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // botonProveedores
            // 
            this.botonProveedores.Location = new System.Drawing.Point(218, 156);
            this.botonProveedores.Name = "botonProveedores";
            this.botonProveedores.Size = new System.Drawing.Size(75, 23);
            this.botonProveedores.TabIndex = 1;
            this.botonProveedores.Text = "Proveedores";
            this.botonProveedores.UseVisualStyleBackColor = true;
            this.botonProveedores.Click += new System.EventHandler(this.botonProveedores_Click);
            // 
            // botonCafé
            // 
            this.botonCafé.Location = new System.Drawing.Point(341, 156);
            this.botonCafé.Name = "botonCafé";
            this.botonCafé.Size = new System.Drawing.Size(75, 23);
            this.botonCafé.TabIndex = 2;
            this.botonCafé.Text = "Café";
            this.botonCafé.UseVisualStyleBackColor = true;
            this.botonCafé.Click += new System.EventHandler(this.botonCafé_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(294, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // botonCerrarSesión
            // 
            this.botonCerrarSesión.Location = new System.Drawing.Point(378, 334);
            this.botonCerrarSesión.Name = "botonCerrarSesión";
            this.botonCerrarSesión.Size = new System.Drawing.Size(96, 23);
            this.botonCerrarSesión.TabIndex = 4;
            this.botonCerrarSesión.Text = "Cerrar Sesión";
            this.botonCerrarSesión.UseVisualStyleBackColor = true;
            this.botonCerrarSesión.Click += new System.EventHandler(this.botonMenúPrincipalCerrarSesión_Click);
            // 
            // botonEntradaYsalidaDeCafé
            // 
            this.botonEntradaYsalidaDeCafé.Location = new System.Drawing.Point(455, 156);
            this.botonEntradaYsalidaDeCafé.Name = "botonEntradaYsalidaDeCafé";
            this.botonEntradaYsalidaDeCafé.Size = new System.Drawing.Size(152, 23);
            this.botonEntradaYsalidaDeCafé.TabIndex = 5;
            this.botonEntradaYsalidaDeCafé.Text = "Entrada y Salida de Café";
            this.botonEntradaYsalidaDeCafé.UseVisualStyleBackColor = true;
            this.botonEntradaYsalidaDeCafé.Click += new System.EventHandler(this.botonEntradaYsalidaDeCafé_Click);
            // 
            // botonVerKardex
            // 
            this.botonVerKardex.Location = new System.Drawing.Point(218, 236);
            this.botonVerKardex.Name = "botonVerKardex";
            this.botonVerKardex.Size = new System.Drawing.Size(75, 23);
            this.botonVerKardex.TabIndex = 6;
            this.botonVerKardex.Text = "Ver Kardex";
            this.botonVerKardex.UseVisualStyleBackColor = true;
            this.botonVerKardex.Click += new System.EventHandler(this.botonVerKardex_Click);
            // 
            // botonVerFacturacionClientes
            // 
            this.botonVerFacturacionClientes.Location = new System.Drawing.Point(625, 155);
            this.botonVerFacturacionClientes.Name = "botonVerFacturacionClientes";
            this.botonVerFacturacionClientes.Size = new System.Drawing.Size(115, 23);
            this.botonVerFacturacionClientes.TabIndex = 7;
            this.botonVerFacturacionClientes.Text = "Facturación Clientes";
            this.botonVerFacturacionClientes.UseVisualStyleBackColor = true;
            this.botonVerFacturacionClientes.Click += new System.EventHandler(this.botonVerFacturacionClientes_Click);
            // 
            // botonVerInformeDeVentas
            // 
            this.botonVerInformeDeVentas.Location = new System.Drawing.Point(325, 236);
            this.botonVerInformeDeVentas.Name = "botonVerInformeDeVentas";
            this.botonVerInformeDeVentas.Size = new System.Drawing.Size(102, 23);
            this.botonVerInformeDeVentas.TabIndex = 8;
            this.botonVerInformeDeVentas.Text = "Informe de Ventas";
            this.botonVerInformeDeVentas.UseVisualStyleBackColor = true;
            this.botonVerInformeDeVentas.Click += new System.EventHandler(this.botonVerInformeDeVentas_Click);
            // 
            // botonVerExistencias
            // 
            this.botonVerExistencias.Location = new System.Drawing.Point(80, 236);
            this.botonVerExistencias.Name = "botonVerExistencias";
            this.botonVerExistencias.Size = new System.Drawing.Size(91, 23);
            this.botonVerExistencias.TabIndex = 9;
            this.botonVerExistencias.Text = "Ver Existencias";
            this.botonVerExistencias.UseVisualStyleBackColor = true;
            this.botonVerExistencias.Click += new System.EventHandler(this.botonVerExistencias_Click);
            // 
            // MenúPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonVerExistencias);
            this.Controls.Add(this.botonVerInformeDeVentas);
            this.Controls.Add(this.botonVerFacturacionClientes);
            this.Controls.Add(this.botonVerKardex);
            this.Controls.Add(this.botonEntradaYsalidaDeCafé);
            this.Controls.Add(this.botonCerrarSesión);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCafé);
            this.Controls.Add(this.botonProveedores);
            this.Controls.Add(this.botonClientes);
            this.Name = "MenúPrincipal";
            this.Text = "MenúPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonProveedores;
        private System.Windows.Forms.Button botonCafé;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCerrarSesión;
        private System.Windows.Forms.Button botonEntradaYsalidaDeCafé;
        private System.Windows.Forms.Button botonVerKardex;
        private System.Windows.Forms.Button botonVerFacturacionClientes;
        private System.Windows.Forms.Button botonVerInformeDeVentas;
        private System.Windows.Forms.Button botonVerExistencias;
    }
}