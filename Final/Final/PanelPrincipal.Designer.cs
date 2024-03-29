﻿namespace Final
{
    partial class PanelPrincipal
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
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnPiezas = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAltaPedidos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAltaModelos = new System.Windows.Forms.Button();
            this.btnAltaPiezas = new System.Windows.Forms.Button();
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroConcesionaria = new System.Windows.Forms.TextBox();
            this.btnEnviarModelo = new System.Windows.Forms.Button();
            this.btnEnviarPieza = new System.Windows.Forms.Button();
            this.btnModificarPedidos = new System.Windows.Forms.Button();
            this.btnModificarModelos = new System.Windows.Forms.Button();
            this.btnModificarPiezas = new System.Windows.Forms.Button();
            this.btnBajaPedidos = new System.Windows.Forms.Button();
            this.btnBajaModelos = new System.Windows.Forms.Button();
            this.btnBajaPiezas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(840, 615);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(192, 86);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "Listar";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.Location = new System.Drawing.Point(1104, 615);
            this.btnModelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(192, 86);
            this.btnModelos.TabIndex = 1;
            this.btnModelos.Text = "Listar";
            this.btnModelos.UseVisualStyleBackColor = true;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnPiezas
            // 
            this.btnPiezas.Location = new System.Drawing.Point(1365, 615);
            this.btnPiezas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPiezas.Name = "btnPiezas";
            this.btnPiezas.Size = new System.Drawing.Size(192, 86);
            this.btnPiezas.TabIndex = 2;
            this.btnPiezas.Text = "Listar";
            this.btnPiezas.UseVisualStyleBackColor = true;
            this.btnPiezas.Click += new System.EventHandler(this.btnPiezas_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(840, 60);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 102;
            this.dgvDatos.RowTemplate.Height = 40;
            this.dgvDatos.Size = new System.Drawing.Size(925, 396);
            this.dgvDatos.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(480, 131);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(265, 38);
            this.txtModelo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(480, 229);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(265, 38);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(480, 408);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(265, 38);
            this.txtCantidad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // btnAltaPedidos
            // 
            this.btnAltaPedidos.Location = new System.Drawing.Point(840, 525);
            this.btnAltaPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaPedidos.Name = "btnAltaPedidos";
            this.btnAltaPedidos.Size = new System.Drawing.Size(192, 86);
            this.btnAltaPedidos.TabIndex = 10;
            this.btnAltaPedidos.Text = "Alta";
            this.btnAltaPedidos.UseVisualStyleBackColor = true;
            this.btnAltaPedidos.Click += new System.EventHandler(this.btnAltaPedidos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(867, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pedidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label5.Location = new System.Drawing.Point(1128, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modelos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.Location = new System.Drawing.Point(1403, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Piezas";
            // 
            // btnAltaModelos
            // 
            this.btnAltaModelos.Location = new System.Drawing.Point(1104, 525);
            this.btnAltaModelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaModelos.Name = "btnAltaModelos";
            this.btnAltaModelos.Size = new System.Drawing.Size(192, 86);
            this.btnAltaModelos.TabIndex = 14;
            this.btnAltaModelos.Text = "Alta";
            this.btnAltaModelos.UseVisualStyleBackColor = true;
            this.btnAltaModelos.Click += new System.EventHandler(this.btnAltaModelos_Click);
            // 
            // btnAltaPiezas
            // 
            this.btnAltaPiezas.Location = new System.Drawing.Point(1365, 525);
            this.btnAltaPiezas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaPiezas.Name = "btnAltaPiezas";
            this.btnAltaPiezas.Size = new System.Drawing.Size(192, 86);
            this.btnAltaPiezas.TabIndex = 15;
            this.btnAltaPiezas.Text = "Alta";
            this.btnAltaPiezas.UseVisualStyleBackColor = true;
            this.btnAltaPiezas.Click += new System.EventHandler(this.btnAltaPiezas_Click);
            // 
            // btnEnviarPedido
            // 
            this.btnEnviarPedido.Location = new System.Drawing.Point(77, 796);
            this.btnEnviarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.Size = new System.Drawing.Size(192, 86);
            this.btnEnviarPedido.TabIndex = 16;
            this.btnEnviarPedido.Text = "Enviar Pedido";
            this.btnEnviarPedido.UseVisualStyleBackColor = true;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Numero de Concesionaria";
            // 
            // txtNroConcesionaria
            // 
            this.txtNroConcesionaria.Location = new System.Drawing.Point(480, 315);
            this.txtNroConcesionaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroConcesionaria.Name = "txtNroConcesionaria";
            this.txtNroConcesionaria.Size = new System.Drawing.Size(265, 38);
            this.txtNroConcesionaria.TabIndex = 19;
            this.txtNroConcesionaria.TextChanged += new System.EventHandler(this.txtNroConcesionaria_TextChanged);
            // 
            // btnEnviarModelo
            // 
            this.btnEnviarModelo.Location = new System.Drawing.Point(275, 796);
            this.btnEnviarModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarModelo.Name = "btnEnviarModelo";
            this.btnEnviarModelo.Size = new System.Drawing.Size(192, 86);
            this.btnEnviarModelo.TabIndex = 20;
            this.btnEnviarModelo.Text = "Enviar Modelo";
            this.btnEnviarModelo.UseVisualStyleBackColor = true;
            this.btnEnviarModelo.Click += new System.EventHandler(this.btnEnviarModelo_Click);
            // 
            // btnEnviarPieza
            // 
            this.btnEnviarPieza.Location = new System.Drawing.Point(472, 796);
            this.btnEnviarPieza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarPieza.Name = "btnEnviarPieza";
            this.btnEnviarPieza.Size = new System.Drawing.Size(192, 86);
            this.btnEnviarPieza.TabIndex = 21;
            this.btnEnviarPieza.Text = "Enviar Pieza";
            this.btnEnviarPieza.UseVisualStyleBackColor = true;
            this.btnEnviarPieza.Click += new System.EventHandler(this.btnEnviarPieza_Click);
            // 
            // btnModificarPedidos
            // 
            this.btnModificarPedidos.Location = new System.Drawing.Point(840, 705);
            this.btnModificarPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarPedidos.Name = "btnModificarPedidos";
            this.btnModificarPedidos.Size = new System.Drawing.Size(192, 86);
            this.btnModificarPedidos.TabIndex = 22;
            this.btnModificarPedidos.Text = "Modificar";
            this.btnModificarPedidos.UseVisualStyleBackColor = true;
            this.btnModificarPedidos.Click += new System.EventHandler(this.btnModificarPedidos_Click);
            // 
            // btnModificarModelos
            // 
            this.btnModificarModelos.Location = new System.Drawing.Point(1104, 705);
            this.btnModificarModelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarModelos.Name = "btnModificarModelos";
            this.btnModificarModelos.Size = new System.Drawing.Size(192, 86);
            this.btnModificarModelos.TabIndex = 23;
            this.btnModificarModelos.Text = "Modificar";
            this.btnModificarModelos.UseVisualStyleBackColor = true;
            this.btnModificarModelos.Click += new System.EventHandler(this.btnModificarModelos_Click);
            // 
            // btnModificarPiezas
            // 
            this.btnModificarPiezas.Location = new System.Drawing.Point(1365, 705);
            this.btnModificarPiezas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarPiezas.Name = "btnModificarPiezas";
            this.btnModificarPiezas.Size = new System.Drawing.Size(192, 86);
            this.btnModificarPiezas.TabIndex = 24;
            this.btnModificarPiezas.Text = "Modificar";
            this.btnModificarPiezas.UseVisualStyleBackColor = true;
            this.btnModificarPiezas.Click += new System.EventHandler(this.btnModificarPiezas_Click);
            // 
            // btnBajaPedidos
            // 
            this.btnBajaPedidos.Location = new System.Drawing.Point(840, 796);
            this.btnBajaPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajaPedidos.Name = "btnBajaPedidos";
            this.btnBajaPedidos.Size = new System.Drawing.Size(192, 86);
            this.btnBajaPedidos.TabIndex = 25;
            this.btnBajaPedidos.Text = "Baja";
            this.btnBajaPedidos.UseVisualStyleBackColor = true;
            this.btnBajaPedidos.Click += new System.EventHandler(this.btnBajaPedidos_Click);
            // 
            // btnBajaModelos
            // 
            this.btnBajaModelos.Location = new System.Drawing.Point(1104, 796);
            this.btnBajaModelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajaModelos.Name = "btnBajaModelos";
            this.btnBajaModelos.Size = new System.Drawing.Size(192, 86);
            this.btnBajaModelos.TabIndex = 26;
            this.btnBajaModelos.Text = "Baja";
            this.btnBajaModelos.UseVisualStyleBackColor = true;
            this.btnBajaModelos.Click += new System.EventHandler(this.btnBajaModelos_Click);
            // 
            // btnBajaPiezas
            // 
            this.btnBajaPiezas.Location = new System.Drawing.Point(1365, 796);
            this.btnBajaPiezas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajaPiezas.Name = "btnBajaPiezas";
            this.btnBajaPiezas.Size = new System.Drawing.Size(192, 86);
            this.btnBajaPiezas.TabIndex = 27;
            this.btnBajaPiezas.Text = "Baja";
            this.btnBajaPiezas.UseVisualStyleBackColor = true;
            this.btnBajaPiezas.Click += new System.EventHandler(this.btnBajaPiezas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1657, 796);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(192, 86);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 906);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBajaPiezas);
            this.Controls.Add(this.btnBajaModelos);
            this.Controls.Add(this.btnBajaPedidos);
            this.Controls.Add(this.btnModificarPiezas);
            this.Controls.Add(this.btnModificarModelos);
            this.Controls.Add(this.btnModificarPedidos);
            this.Controls.Add(this.btnEnviarPieza);
            this.Controls.Add(this.btnEnviarModelo);
            this.Controls.Add(this.txtNroConcesionaria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEnviarPedido);
            this.Controls.Add(this.btnAltaPiezas);
            this.Controls.Add(this.btnAltaModelos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAltaPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnPiezas);
            this.Controls.Add(this.btnModelos);
            this.Controls.Add(this.btnPedidos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelPrincipal";
            this.Text = "Panel Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnPiezas;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAltaPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAltaModelos;
        private System.Windows.Forms.Button btnAltaPiezas;
        private System.Windows.Forms.Button btnEnviarPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNroConcesionaria;
        private System.Windows.Forms.Button btnEnviarModelo;
        private System.Windows.Forms.Button btnEnviarPieza;
        private System.Windows.Forms.Button btnModificarPedidos;
        private System.Windows.Forms.Button btnModificarModelos;
        private System.Windows.Forms.Button btnModificarPiezas;
        private System.Windows.Forms.Button btnBajaPedidos;
        private System.Windows.Forms.Button btnBajaModelos;
        private System.Windows.Forms.Button btnBajaPiezas;
        private System.Windows.Forms.Button btnVolver;
    }
}