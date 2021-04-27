﻿using Control_de_Inventario.Formularios.Formularios_para_busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Control_de_Inventario
{
    public partial class FrmTransacciones : Form
    {
        public FrmTransacciones()
        {
            InitializeComponent();
        }

        private void BtnIDArticulo_Click(object sender, EventArgs e)
        {
            FrmBusquedaArticulo busqArti = new FrmBusquedaArticulo();
            busqArti.Show();
        }

        private void BtnBodega_Click(object sender, EventArgs e)
        {
            FrmBusquedaBodega busqBo = new FrmBusquedaBodega();
            busqBo.Show();
        }

        private void BtnIDTransaccion_Click(object sender, EventArgs e)
        {
            FrmBusquedaTransaccion busqTran = new FrmBusquedaTransaccion();
            busqTran.Show();
        }
    }
}
