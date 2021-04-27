
namespace Control_de_Inventario.Formularios.Formularios_para_busquedas
{
    partial class FrmBusquedaBodega
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
            this.dgvBodega = new System.Windows.Forms.DataGridView();
            this.dgvIDBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEnvase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreBodega = new System.Windows.Forms.TextBox();
            this.txtIDBodega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBodega
            // 
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIDBodega,
            this.dgvNombreBodega,
            this.dgvUbicacion,
            this.dgvEnvase,
            this.dgvEstado});
            this.dgvBodega.Location = new System.Drawing.Point(322, 13);
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.RowTemplate.Height = 25;
            this.dgvBodega.Size = new System.Drawing.Size(516, 322);
            this.dgvBodega.TabIndex = 3;
            // 
            // dgvIDBodega
            // 
            this.dgvIDBodega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvIDBodega.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIDBodega.HeaderText = "ID Bodega";
            this.dgvIDBodega.Name = "dgvIDBodega";
            this.dgvIDBodega.ReadOnly = true;
            this.dgvIDBodega.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIDBodega.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvIDBodega.Width = 60;
            // 
            // dgvNombreBodega
            // 
            this.dgvNombreBodega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvNombreBodega.HeaderText = "Nombre";
            this.dgvNombreBodega.Name = "dgvNombreBodega";
            this.dgvNombreBodega.ReadOnly = true;
            this.dgvNombreBodega.Width = 76;
            // 
            // dgvUbicacion
            // 
            this.dgvUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvUbicacion.HeaderText = "Ubicación";
            this.dgvUbicacion.Name = "dgvUbicacion";
            this.dgvUbicacion.ReadOnly = true;
            this.dgvUbicacion.Width = 72;
            // 
            // dgvEnvase
            // 
            this.dgvEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvEnvase.HeaderText = "Fecha de creación";
            this.dgvEnvase.Name = "dgvEnvase";
            this.dgvEnvase.ReadOnly = true;
            this.dgvEnvase.Width = 104;
            // 
            // dgvEstado
            // 
            this.dgvEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvEstado.HeaderText = "Estado";
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.Width = 67;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtFechaCreacion);
            this.panel1.Controls.Add(this.txtUbicacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreBodega);
            this.panel1.Controls.Add(this.txtIDBodega);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 323);
            this.panel1.TabIndex = 2;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "",
            "Activo",
            "En espera...",
            "Cerrado"});
            this.cbEstado.Location = new System.Drawing.Point(142, 132);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(141, 23);
            this.cbEstado.TabIndex = 32;
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
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFechaCreacion.Location = new System.Drawing.Point(142, 104);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(141, 21);
            this.txtFechaCreacion.TabIndex = 24;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUbicacion.Location = new System.Drawing.Point(142, 77);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(141, 21);
            this.txtUbicacion.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de creación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ubicación";
            // 
            // txtNombreBodega
            // 
            this.txtNombreBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreBodega.Location = new System.Drawing.Point(142, 50);
            this.txtNombreBodega.Name = "txtNombreBodega";
            this.txtNombreBodega.Size = new System.Drawing.Size(141, 21);
            this.txtNombreBodega.TabIndex = 17;
            // 
            // txtIDBodega
            // 
            this.txtIDBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDBodega.Location = new System.Drawing.Point(142, 23);
            this.txtIDBodega.Name = "txtIDBodega";
            this.txtIDBodega.Size = new System.Drawing.Size(141, 21);
            this.txtIDBodega.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Bodega";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(28, 53);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(114, 15);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Nombre de bodega";
            // 
            // FrmBusquedaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(851, 346);
            this.Controls.Add(this.dgvBodega);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBusquedaBodega";
            this.Text = "PROLAC - Buscador de bodega";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBodega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDBodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEnvase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
        private System.Windows.Forms.TextBox txtNombreBodega;
    }
}