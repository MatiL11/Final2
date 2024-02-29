namespace Final
{
    partial class Form2
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
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNroConcesionaria = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPedidoExitoso = new System.Windows.Forms.DataGridView();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoExitoso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.Location = new System.Drawing.Point(32, 773);
            this.btnEnviarPedido.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(280, 110);
            this.btnEnviarPedido.TabIndex = 0;
            this.btnEnviarPedido.Text = "Enviar Pedido";
            this.btnEnviarPedido.UseVisualStyleBackColor = true;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(43, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(43, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de concesionaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(43, 627);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad pedida";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(507, 224);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(273, 38);
            this.txtModelo.TabIndex = 4;
            // 
            // txtNroConcesionaria
            // 
            this.txtNroConcesionaria.Location = new System.Drawing.Point(507, 427);
            this.txtNroConcesionaria.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNroConcesionaria.Name = "txtNroConcesionaria";
            this.txtNroConcesionaria.Size = new System.Drawing.Size(273, 38);
            this.txtNroConcesionaria.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(507, 625);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(273, 38);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1755, 773);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(280, 110);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(251, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Realizar pedidos";
            // 
            // dgvPedidoExitoso
            // 
            this.dgvPedidoExitoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoExitoso.Location = new System.Drawing.Point(981, 217);
            this.dgvPedidoExitoso.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPedidoExitoso.Name = "dgvPedidoExitoso";
            this.dgvPedidoExitoso.RowHeadersWidth = 102;
            this.dgvPedidoExitoso.Size = new System.Drawing.Size(1053, 448);
            this.dgvPedidoExitoso.TabIndex = 9;
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Location = new System.Drawing.Point(981, 773);
            this.btnGuardarArchivo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(280, 110);
            this.btnGuardarArchivo.TabIndex = 10;
            this.btnGuardarArchivo.Text = "Realizar Alta";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(2067, 942);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.dgvPedidoExitoso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNroConcesionaria);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarPedido);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form2";
            this.Text = "Realizar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoExitoso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNroConcesionaria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPedidoExitoso;
        private System.Windows.Forms.Button btnGuardarArchivo;
    }
}