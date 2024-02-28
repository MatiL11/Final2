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
            this.btnEnviarPedido.Location = new System.Drawing.Point(12, 324);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(105, 46);
            this.btnEnviarPedido.TabIndex = 0;
            this.btnEnviarPedido.Text = "Enviar Pedido";
            this.btnEnviarPedido.UseVisualStyleBackColor = true;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de concesionaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(16, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad pedida";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(190, 94);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(105, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtNroConcesionaria
            // 
            this.txtNroConcesionaria.Location = new System.Drawing.Point(190, 179);
            this.txtNroConcesionaria.Name = "txtNroConcesionaria";
            this.txtNroConcesionaria.Size = new System.Drawing.Size(105, 20);
            this.txtNroConcesionaria.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(190, 262);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(105, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(658, 324);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 46);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(94, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Realizar pedidos";
            // 
            // dgvPedidoExitoso
            // 
            this.dgvPedidoExitoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoExitoso.Location = new System.Drawing.Point(368, 91);
            this.dgvPedidoExitoso.Name = "dgvPedidoExitoso";
            this.dgvPedidoExitoso.Size = new System.Drawing.Size(395, 188);
            this.dgvPedidoExitoso.TabIndex = 9;
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.Location = new System.Drawing.Point(368, 324);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(105, 46);
            this.btnGuardarArchivo.TabIndex = 10;
            this.btnGuardarArchivo.Text = "Guardar Archivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = true;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(775, 395);
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