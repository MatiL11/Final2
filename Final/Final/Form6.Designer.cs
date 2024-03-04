namespace Final
{
    partial class Form6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(839, 485);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(191, 85);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "Alta Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.Location = new System.Drawing.Point(1036, 485);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(191, 85);
            this.btnModelos.TabIndex = 1;
            this.btnModelos.Text = "Alta Modelos";
            this.btnModelos.UseVisualStyleBackColor = true;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnPiezas
            // 
            this.btnPiezas.Location = new System.Drawing.Point(1233, 485);
            this.btnPiezas.Name = "btnPiezas";
            this.btnPiezas.Size = new System.Drawing.Size(191, 85);
            this.btnPiezas.TabIndex = 2;
            this.btnPiezas.Text = "Alta Piezas";
            this.btnPiezas.UseVisualStyleBackColor = true;
            this.btnPiezas.Click += new System.EventHandler(this.btnPiezas_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(839, 59);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 102;
            this.dgvDatos.RowTemplate.Height = 40;
            this.dgvDatos.Size = new System.Drawing.Size(926, 397);
            this.dgvDatos.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 38);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 38);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 418);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 38);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 906);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnPiezas);
            this.Controls.Add(this.btnModelos);
            this.Controls.Add(this.btnPedidos);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnPiezas;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}