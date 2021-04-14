using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Control_de_Inventario
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            FrmTransacciones trans = new FrmTransacciones();
            trans.Show();
        }
    } 
}
