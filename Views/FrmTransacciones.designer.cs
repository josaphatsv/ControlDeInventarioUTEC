
namespace Control_de_Inventario
{
    partial class FrmTransacciones
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
            this.panelTransaccion = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardad = new System.Windows.Forms.Button();
            this.labelUMArticulo = new System.Windows.Forms.Label();
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.btnIDArticulo = new System.Windows.Forms.Button();
            this.btnIDTransaccion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.btnBodega = new System.Windows.Forms.Button();
            this.grupBoxTipoTrasaccion = new System.Windows.Forms.GroupBox();
            this.rBtnAjusteSalida = new System.Windows.Forms.RadioButton();
            this.rBtnAjusteEntrada = new System.Windows.Forms.RadioButton();
            this.rBtnEmitir = new System.Windows.Forms.RadioButton();
            this.txtIDArticulo = new System.Windows.Forms.TextBox();
            this.txtIDTransaccion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHabilitado = new System.Windows.Forms.TextBox();
            this.txtDisponible = new System.Windows.Forms.TextBox();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTransaccion = new System.Windows.Forms.DateTimePicker();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTransaccion.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grupBoxTipoTrasaccion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTransaccion
            // 
            this.panelTransaccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTransaccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTransaccion.Controls.Add(this.btnEliminar);
            this.panelTransaccion.Controls.Add(this.btnGuardad);
            this.panelTransaccion.Controls.Add(this.labelUMArticulo);
            this.panelTransaccion.Controls.Add(this.labelNombreArticulo);
            this.panelTransaccion.Controls.Add(this.btnIDArticulo);
            this.panelTransaccion.Controls.Add(this.btnIDTransaccion);
            this.panelTransaccion.Controls.Add(this.panel3);
            this.panelTransaccion.Controls.Add(this.grupBoxTipoTrasaccion);
            this.panelTransaccion.Controls.Add(this.txtIDArticulo);
            this.panelTransaccion.Controls.Add(this.txtIDTransaccion);
            this.panelTransaccion.Controls.Add(this.panel2);
            this.panelTransaccion.Controls.Add(this.label2);
            this.panelTransaccion.Controls.Add(this.dateTransaccion);
            this.panelTransaccion.Controls.Add(this.txtIDUsuario);
            this.panelTransaccion.Controls.Add(this.label1);
            this.panelTransaccion.Location = new System.Drawing.Point(12, 12);
            this.panelTransaccion.Name = "panelTransaccion";
            this.panelTransaccion.Size = new System.Drawing.Size(663, 384);
            this.panelTransaccion.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(539, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 28);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardad
            // 
            this.btnGuardad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardad.Location = new System.Drawing.Point(430, 342);
            this.btnGuardad.Name = "btnGuardad";
            this.btnGuardad.Size = new System.Drawing.Size(103, 28);
            this.btnGuardad.TabIndex = 15;
            this.btnGuardad.Text = "Guardar";
            this.btnGuardad.UseVisualStyleBackColor = true;
            // 
            // labelUMArticulo
            // 
            this.labelUMArticulo.AutoSize = true;
            this.labelUMArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUMArticulo.Location = new System.Drawing.Point(138, 144);
            this.labelUMArticulo.Name = "labelUMArticulo";
            this.labelUMArticulo.Size = new System.Drawing.Size(109, 15);
            this.labelUMArticulo.TabIndex = 14;
            this.labelUMArticulo.Text = "Unidad de Medida";
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.AutoSize = true;
            this.labelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreArticulo.Location = new System.Drawing.Point(138, 118);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(112, 15);
            this.labelNombreArticulo.TabIndex = 13;
            this.labelNombreArticulo.Text = "Nombre de Artículo";
            // 
            // btnIDArticulo
            // 
            this.btnIDArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIDArticulo.Location = new System.Drawing.Point(7, 91);
            this.btnIDArticulo.Name = "btnIDArticulo";
            this.btnIDArticulo.Size = new System.Drawing.Size(125, 26);
            this.btnIDArticulo.TabIndex = 12;
            this.btnIDArticulo.Text = "ID Artículo";
            this.btnIDArticulo.UseVisualStyleBackColor = true;
            this.btnIDArticulo.Click += new System.EventHandler(this.BtnIDArticulo_Click);
            // 
            // btnIDTransaccion
            // 
            this.btnIDTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIDTransaccion.Location = new System.Drawing.Point(7, 55);
            this.btnIDTransaccion.Name = "btnIDTransaccion";
            this.btnIDTransaccion.Size = new System.Drawing.Size(125, 26);
            this.btnIDTransaccion.TabIndex = 11;
            this.btnIDTransaccion.Text = "ID Transacción";
            this.btnIDTransaccion.UseVisualStyleBackColor = true;
            this.btnIDTransaccion.Click += new System.EventHandler(this.BtnIDTransaccion_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtBodega);
            this.panel3.Controls.Add(this.btnBodega);
            this.panel3.Location = new System.Drawing.Point(214, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 148);
            this.panel3.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(90, 104);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(312, 23);
            this.txtDescripcion.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descripción";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.Location = new System.Drawing.Point(124, 51);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(122, 21);
            this.txtCantidad.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cantidad";
            // 
            // txtBodega
            // 
            this.txtBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBodega.Location = new System.Drawing.Point(124, 16);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(122, 21);
            this.txtBodega.TabIndex = 8;
            // 
            // btnBodega
            // 
            this.btnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBodega.Location = new System.Drawing.Point(12, 11);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(94, 26);
            this.btnBodega.TabIndex = 0;
            this.btnBodega.Text = "Bodega";
            this.btnBodega.UseVisualStyleBackColor = true;
            this.btnBodega.Click += new System.EventHandler(this.BtnBodega_Click);
            // 
            // grupBoxTipoTrasaccion
            // 
            this.grupBoxTipoTrasaccion.Controls.Add(this.rBtnAjusteSalida);
            this.grupBoxTipoTrasaccion.Controls.Add(this.rBtnAjusteEntrada);
            this.grupBoxTipoTrasaccion.Controls.Add(this.rBtnEmitir);
            this.grupBoxTipoTrasaccion.Location = new System.Drawing.Point(31, 171);
            this.grupBoxTipoTrasaccion.Name = "grupBoxTipoTrasaccion";
            this.grupBoxTipoTrasaccion.Size = new System.Drawing.Size(164, 154);
            this.grupBoxTipoTrasaccion.TabIndex = 9;
            this.grupBoxTipoTrasaccion.TabStop = false;
            this.grupBoxTipoTrasaccion.Text = "Tipo de transacción";
            // 
            // rBtnAjusteSalida
            // 
            this.rBtnAjusteSalida.AutoSize = true;
            this.rBtnAjusteSalida.Location = new System.Drawing.Point(6, 72);
            this.rBtnAjusteSalida.Name = "rBtnAjusteSalida";
            this.rBtnAjusteSalida.Size = new System.Drawing.Size(94, 19);
            this.rBtnAjusteSalida.TabIndex = 12;
            this.rBtnAjusteSalida.TabStop = true;
            this.rBtnAjusteSalida.Text = "Ajuste/Salida";
            this.rBtnAjusteSalida.UseVisualStyleBackColor = true;
            // 
            // rBtnAjusteEntrada
            // 
            this.rBtnAjusteEntrada.AutoSize = true;
            this.rBtnAjusteEntrada.Location = new System.Drawing.Point(6, 47);
            this.rBtnAjusteEntrada.Name = "rBtnAjusteEntrada";
            this.rBtnAjusteEntrada.Size = new System.Drawing.Size(103, 19);
            this.rBtnAjusteEntrada.TabIndex = 11;
            this.rBtnAjusteEntrada.TabStop = true;
            this.rBtnAjusteEntrada.Text = "Ajuste/Entrada";
            this.rBtnAjusteEntrada.UseVisualStyleBackColor = true;
            // 
            // rBtnEmitir
            // 
            this.rBtnEmitir.AutoSize = true;
            this.rBtnEmitir.Location = new System.Drawing.Point(6, 22);
            this.rBtnEmitir.Name = "rBtnEmitir";
            this.rBtnEmitir.Size = new System.Drawing.Size(56, 19);
            this.rBtnEmitir.TabIndex = 10;
            this.rBtnEmitir.TabStop = true;
            this.rBtnEmitir.Text = "Emitir";
            this.rBtnEmitir.UseVisualStyleBackColor = true;
            // 
            // txtIDArticulo
            // 
            this.txtIDArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDArticulo.Location = new System.Drawing.Point(138, 94);
            this.txtIDArticulo.Name = "txtIDArticulo";
            this.txtIDArticulo.Size = new System.Drawing.Size(122, 21);
            this.txtIDArticulo.TabIndex = 7;
            // 
            // txtIDTransaccion
            // 
            this.txtIDTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDTransaccion.Location = new System.Drawing.Point(138, 58);
            this.txtIDTransaccion.Name = "txtIDTransaccion";
            this.txtIDTransaccion.Size = new System.Drawing.Size(122, 21);
            this.txtIDTransaccion.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtHabilitado);
            this.panel2.Controls.Add(this.txtDisponible);
            this.panel2.Controls.Add(this.txtRecibido);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(394, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 110);
            this.panel2.TabIndex = 4;
            // 
            // txtHabilitado
            // 
            this.txtHabilitado.Enabled = false;
            this.txtHabilitado.Location = new System.Drawing.Point(104, 72);
            this.txtHabilitado.Name = "txtHabilitado";
            this.txtHabilitado.Size = new System.Drawing.Size(118, 23);
            this.txtHabilitado.TabIndex = 5;
            // 
            // txtDisponible
            // 
            this.txtDisponible.Enabled = false;
            this.txtDisponible.Location = new System.Drawing.Point(104, 43);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.Size = new System.Drawing.Size(118, 23);
            this.txtDisponible.TabIndex = 4;
            // 
            // txtRecibido
            // 
            this.txtRecibido.Enabled = false;
            this.txtRecibido.Location = new System.Drawing.Point(104, 14);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(118, 23);
            this.txtRecibido.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Habilitado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Disponible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recibido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(409, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de transacción";
            // 
            // dateTransaccion
            // 
            this.dateTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTransaccion.Location = new System.Drawing.Point(539, 22);
            this.dateTransaccion.Name = "dateTransaccion";
            this.dateTransaccion.Size = new System.Drawing.Size(98, 21);
            this.dateTransaccion.TabIndex = 2;
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Enabled = false;
            this.txtIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDUsuario.Location = new System.Drawing.Point(138, 19);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(122, 21);
            this.txtIDUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario";
            // 
            // FrmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(687, 408);
            this.Controls.Add(this.panelTransaccion);
            this.Name = "FrmTransacciones";
            this.Text = "PROLAC - Transacciones de Inventario";
            this.panelTransaccion.ResumeLayout(false);
            this.panelTransaccion.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grupBoxTipoTrasaccion.ResumeLayout(false);
            this.grupBoxTipoTrasaccion.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTransaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTransaccion;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHabilitado;
        private System.Windows.Forms.TextBox txtDisponible;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDTransaccion;
        private System.Windows.Forms.TextBox txtIDArticulo;
        private System.Windows.Forms.GroupBox grupBoxTipoTrasaccion;
        private System.Windows.Forms.RadioButton rBtnEmitir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.Button btnBodega;
        private System.Windows.Forms.RadioButton rBtnAjusteSalida;
        private System.Windows.Forms.RadioButton rBtnAjusteEntrada;
        private System.Windows.Forms.Button btnIDArticulo;
        private System.Windows.Forms.Button btnIDTransaccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelUMArticulo;
        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardad;
    }
}