using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contro_de_Inventario.Views
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            using(Models.inventarioEntities db=new Models.inventarioEntities())
            {
                var lst = from user in db.usuarios
                          select user;
                dgvUsuarios.DataSource = lst.ToList();
            }
        }
    }
}
