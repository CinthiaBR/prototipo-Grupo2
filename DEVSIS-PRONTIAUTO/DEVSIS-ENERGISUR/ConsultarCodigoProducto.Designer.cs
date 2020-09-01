namespace DEVSIS_ENERGISUR
{
    partial class ConsultarCodigoProducto
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
            this.botonRegresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelConsultarProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(435, 419);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(247, 22);
            this.botonRegresar.TabIndex = 48;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(25, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 325);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // botonConsultar
            // 
            this.botonConsultar.Location = new System.Drawing.Point(120, 419);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(247, 22);
            this.botonConsultar.TabIndex = 46;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(282, 41);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(316, 20);
            this.textCodigo.TabIndex = 45;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(117, 48);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(78, 13);
            this.labelCodigo.TabIndex = 44;
            this.labelCodigo.Text = "código artículo";
            // 
            // labelConsultarProducto
            // 
            this.labelConsultarProducto.AutoSize = true;
            this.labelConsultarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultarProducto.Location = new System.Drawing.Point(316, 10);
            this.labelConsultarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarProducto.Name = "labelConsultarProducto";
            this.labelConsultarProducto.Size = new System.Drawing.Size(257, 18);
            this.labelConsultarProducto.TabIndex = 43;
            this.labelConsultarProducto.Text = "Consultar artículo mantenimiento";
            // 
            // ConsultarCodigoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelConsultarProducto);
            this.Name = "ConsultarCodigoProducto";
            this.Text = "Consultar producto por código";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelConsultarProducto;
    }
}