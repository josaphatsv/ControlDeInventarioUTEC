using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contro_de_Inventario;
using System.Windows.Forms;


namespace Control_de_Inventario
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnTransacciones_Click(object sender, EventArgs e)
        {
            FrmTransacciones trans = new FrmTransacciones();
            trans.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios user = new frmUsuarios();
            user.Show();
        }
    } 
}
