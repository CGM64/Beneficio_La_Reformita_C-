
namespace Frontend
{
    partial class InformeDeVentas
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
            this.listaInformeDeVentas = new System.Windows.Forms.DataGridView();
            this.botonCerrarFormulario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaInformeDeVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(302, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de Ventas";
            // 
            // listaInformeDeVentas
            // 
            this.listaInformeDeVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaInformeDeVentas.Location = new System.Drawing.Point(12, 83);
            this.listaInformeDeVentas.Name = "listaInformeDeVentas";
            this.listaInformeDeVentas.Size = new System.Drawing.Size(776, 211);
            this.listaInformeDeVentas.TabIndex = 1;
            // 
            // botonCerrarFormulario
            // 
            this.botonCerrarFormulario.Location = new System.Drawing.Point(621, 399);
            this.botonCerrarFormulario.Name = "botonCerrarFormulario";
            this.botonCerrarFormulario.Size = new System.Drawing.Size(115, 23);
            this.botonCerrarFormulario.TabIndex = 2;
            this.botonCerrarFormulario.Text = "Cerrar Formulario";
            this.botonCerrarFormulario.UseVisualStyleBackColor = true;
            this.botonCerrarFormulario.Click += new System.EventHandler(this.botonCerrarFormulario_Click);
            // 
            // InformeDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCerrarFormulario);
            this.Controls.Add(this.listaInformeDeVentas);
            this.Controls.Add(this.label1);
            this.Name = "InformeDeVentas";
            this.Text = "InformeDeVentas";
            this.Load += new System.EventHandler(this.InformeDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaInformeDeVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaInformeDeVentas;
        private System.Windows.Forms.Button botonCerrarFormulario;
    }
}