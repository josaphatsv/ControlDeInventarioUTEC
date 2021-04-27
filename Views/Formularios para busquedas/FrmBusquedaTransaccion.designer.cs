
namespace Control_de_Inventario.Formularios.Formularios_para_busquedas
{
    partial class FrmBusquedaTransaccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTransaccion = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFechaTransaccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDArtículo = new System.Windows.Forms.TextBox();
            this.txtIDTransaccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.cbTipoTransaccion = new System.Windows.Forms.ComboBox();
            this.txtIDBodega = new System.Windows.Forms.TextBox();
            this.dgvIDTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIDArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIDBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaccion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaccion
            // 
            this.dgvTransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIDTransaccion,
            this.dgvIDArticulo,
            this.dgvTipoTransaccion,
            this.dgvFechaTransaccion,
            this.dgvIDBodega});
            this.dgvTransaccion.Location = new System.Drawing.Point(322, 13);
            this.dgvTransaccion.Name = "dgvTransaccion";
            this.dgvTransaccion.RowTemplate.Height = 25;
            this.dgvTransaccion.Size = new System.Drawing.Size(516, 322);
            this.dgvTransaccion.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIDBodega);
            this.panel1.Controls.Add(this.cbTipoTransaccion);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtFechaTransaccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIDArtículo);
            this.panel1.Controls.Add(this.txtIDTransaccion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 323);
            this.panel1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(28, 275);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(255, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtFechaTransaccion
            // 
            this.txtFechaTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFechaTransaccion.Location = new System.Drawing.Point(142, 104);
            this.txtFechaTransaccion.Name = "txtFechaTransaccion";
            this.txtFechaTransaccion.Size = new System.Drawing.Size(141, 21);
            this.txtFechaTransaccion.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID Bodega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de transacción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo de transacción";
            // 
            // txtIDArtículo
            // 
            this.txtIDArtículo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDArtículo.Location = new System.Drawing.Point(142, 50);
            this.txtIDArtículo.Name = "txtIDArtículo";
            this.txtIDArtículo.Size = new System.Drawing.Size(141, 21);
            this.txtIDArtículo.TabIndex = 17;
            // 
            // txtIDTransaccion
            // 
            this.txtIDTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDTransaccion.Location = new System.Drawing.Point(142, 23);
            this.txtIDTransaccion.Name = "txtIDTransaccion";
            this.txtIDTransaccion.Size = new System.Drawing.Size(141, 21);
            this.txtIDTransaccion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Transacción";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(18, 53);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 15);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "ID Artículo";
            // 
            // cbTipoTransaccion
            // 
            this.cbTipoTransaccion.FormattingEnabled = true;
            this.cbTipoTransaccion.Items.AddRange(new object[] {
            "",
            "Emitir",
            "Ajuste/Entrada",
            "Ajuste/Salida"});
            this.cbTipoTransaccion.Location = new System.Drawing.Point(142, 75);
            this.cbTipoTransaccion.Name = "cbTipoTransaccion";
            this.cbTipoTransaccion.Size = new System.Drawing.Size(141, 23);
            this.cbTipoTransaccion.TabIndex = 33;
            // 
            // txtIDBodega
            // 
            this.txtIDBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDBodega.Location = new System.Drawing.Point(142, 134);
            this.txtIDBodega.Name = "txtIDBodega";
            this.txtIDBodega.Size = new System.Drawing.Size(141, 21);
            this.txtIDBodega.TabIndex = 34;
            // 
            // dgvIDTransaccion
            // 
            this.dgvIDTransaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvIDTransaccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIDTransaccion.HeaderText = "ID Transacción";
            this.dgvIDTransaccion.Name = "dgvIDTransaccion";
            this.dgvIDTransaccion.ReadOnly = true;
            this.dgvIDTransaccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIDTransaccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvIDTransaccion.Width = 89;
            // 
            // dgvIDArticulo
            // 
            this.dgvIDArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvIDArticulo.HeaderText = "ID Artículo";
            this.dgvIDArticulo.Name = "dgvIDArticulo";
            this.dgvIDArticulo.ReadOnly = true;
            this.dgvIDArticulo.Width = 88;
            // 
            // dgvTipoTransaccion
            // 
            this.dgvTipoTransaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTipoTransaccion.HeaderText = "Transacción";
            this.dgvTipoTransaccion.Name = "dgvTipoTransaccion";
            this.dgvTipoTransaccion.ReadOnly = true;
            this.dgvTipoTransaccion.Width = 94;
            // 
            // dgvFechaTransaccion
            // 
            this.dgvFechaTransaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvFechaTransaccion.HeaderText = "Fecha de transacción";
            this.dgvFechaTransaccion.Name = "dgvFechaTransaccion";
            this.dgvFechaTransaccion.ReadOnly = true;
            this.dgvFechaTransaccion.Width = 118;
            // 
            // dgvIDBodega
            // 
            this.dgvIDBodega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvIDBodega.HeaderText = "ID Bodega";
            this.dgvIDBodega.Name = "dgvIDBodega";
            this.dgvIDBodega.ReadOnly = true;
            this.dgvIDBodega.Width = 79;
            // 
            // FrmBusquedaTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(847, 343);
            this.Controls.Add(this.dgvTransaccion);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBusquedaTransaccion";
            this.Text = "PROLAC - Buscador de transacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaccion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFechaTransaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDArtículo;
        private System.Windows.Forms.TextBox txtIDTransaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox cbTipoTransaccion;
        private System.Windows.Forms.TextBox txtIDBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDBodega;
    }
}