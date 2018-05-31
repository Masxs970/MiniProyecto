namespace ProyectoTienda
{
    partial class Productos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewProductos = new System.Windows.Forms.Button();
            this.SalirProductos = new System.Windows.Forms.Button();
            this.ClientesProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewProductos
            // 
            this.ViewProductos.Location = new System.Drawing.Point(12, 295);
            this.ViewProductos.Name = "ViewProductos";
            this.ViewProductos.Size = new System.Drawing.Size(177, 23);
            this.ViewProductos.TabIndex = 1;
            this.ViewProductos.Text = "Productos";
            this.ViewProductos.UseVisualStyleBackColor = true;
            // 
            // SalirProductos
            // 
            this.SalirProductos.Location = new System.Drawing.Point(627, 342);
            this.SalirProductos.Name = "SalirProductos";
            this.SalirProductos.Size = new System.Drawing.Size(93, 23);
            this.SalirProductos.TabIndex = 3;
            this.SalirProductos.Text = "Salir";
            this.SalirProductos.UseVisualStyleBackColor = true;
            this.SalirProductos.Click += new System.EventHandler(this.SalirProductos_Click);
            // 
            // ClientesProductos
            // 
            this.ClientesProductos.Location = new System.Drawing.Point(225, 295);
            this.ClientesProductos.Name = "ClientesProductos";
            this.ClientesProductos.Size = new System.Drawing.Size(184, 23);
            this.ClientesProductos.TabIndex = 4;
            this.ClientesProductos.Text = "Clientes";
            this.ClientesProductos.UseVisualStyleBackColor = true;
            this.ClientesProductos.Click += new System.EventHandler(this.ClientesProductos_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 377);
            this.Controls.Add(this.ClientesProductos);
            this.Controls.Add(this.SalirProductos);
            this.Controls.Add(this.ViewProductos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewProductos;
        private System.Windows.Forms.Button SalirProductos;
        private System.Windows.Forms.Button ClientesProductos;
    }
}