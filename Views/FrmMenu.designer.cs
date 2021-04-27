
namespace Control_de_Inventario
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnBodega = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Location = new System.Drawing.Point(17, 13);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(192, 59);
            this.btnUsuarios.TabIndex = 20;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Location = new System.Drawing.Point(17, 246);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(192, 59);
            this.btnReportes.TabIndex = 19;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnTransacciones.ForeColor = System.Drawing.Color.Black;
            this.btnTransacciones.Location = new System.Drawing.Point(17, 116);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(192, 59);
            this.btnTransacciones.TabIndex = 18;
            this.btnTransacciones.Text = "TRANSACCIONES";
            this.btnTransacciones.UseVisualStyleBackColor = false;
            this.btnTransacciones.Click += new System.EventHandler(this.BtnTransacciones_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.Color.Black;
            this.btnInventario.Location = new System.Drawing.Point(17, 181);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(192, 59);
            this.btnInventario.TabIndex = 17;
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnArticulos.ForeColor = System.Drawing.Color.Black;
            this.btnArticulos.Location = new System.Drawing.Point(216, 246);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(192, 59);
            this.btnArticulos.TabIndex = 16;
            this.btnArticulos.Text = "ARTICULOS";
            this.btnArticulos.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnProveedores.Location = new System.Drawing.Point(216, 181);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(192, 59);
            this.btnProveedores.TabIndex = 15;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnBodega
            // 
            this.btnBodega.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBodega.ForeColor = System.Drawing.Color.Black;
            this.btnBodega.Location = new System.Drawing.Point(216, 116);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(192, 59);
            this.btnBodega.TabIndex = 14;
            this.btnBodega.Text = "BODEGA";
            this.btnBodega.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnBodega);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.btnTransacciones);
            this.panel1.Controls.Add(this.btnArticulos);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Location = new System.Drawing.Point(14, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 326);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contro_de_Inventario.Properties.Resources.ProLac;
            this.pictureBox1.InitialImage = global::Contro_de_Inventario.Properties.Resources.ProLac;
            this.pictureBox1.Location = new System.Drawing.Point(278, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 80);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usuario: ";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelUsuario.Location = new System.Drawing.Point(103, 10);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(86, 25);
            this.labelUsuario.TabIndex = 23;
            this.labelUsuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(271, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Rol: ";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelRol.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelRol.Location = new System.Drawing.Point(325, 10);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(43, 25);
            this.labelRol.TabIndex = 25;
            this.labelRol.Text = "Rol";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 375);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROLAC - Menú";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnBodega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRol;
    }
}

