namespace Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStockPiezas = new System.Windows.Forms.Button();
            this.btnStockModelos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Location = new System.Drawing.Point(117, 131);
            this.btnRealizarPedido.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(272, 95);
            this.btnRealizarPedido.TabIndex = 0;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(117, 570);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(272, 95);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(117, 460);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(272, 95);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(83, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Principal";
            // 
            // btnStockPiezas
            // 
            this.btnStockPiezas.Location = new System.Drawing.Point(117, 351);
            this.btnStockPiezas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnStockPiezas.Name = "btnStockPiezas";
            this.btnStockPiezas.Size = new System.Drawing.Size(272, 95);
            this.btnStockPiezas.TabIndex = 4;
            this.btnStockPiezas.Text = "Stock Piezas";
            this.btnStockPiezas.UseVisualStyleBackColor = true;
            this.btnStockPiezas.Click += new System.EventHandler(this.btnStockPiezas_Click);
            // 
            // btnStockModelos
            // 
            this.btnStockModelos.Location = new System.Drawing.Point(117, 241);
            this.btnStockModelos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnStockModelos.Name = "btnStockModelos";
            this.btnStockModelos.Size = new System.Drawing.Size(272, 95);
            this.btnStockModelos.TabIndex = 5;
            this.btnStockModelos.Text = "Stock Modelos";
            this.btnStockModelos.UseVisualStyleBackColor = true;
            this.btnStockModelos.Click += new System.EventHandler(this.btnStockModelos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 92);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(779, 715);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStockModelos);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnStockPiezas);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStockPiezas;
        private System.Windows.Forms.Button btnStockModelos;
        private System.Windows.Forms.Button button1;
    }
}

