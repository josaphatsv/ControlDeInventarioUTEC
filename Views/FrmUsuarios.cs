using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contro_de_Inventario
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            RefreshdtgUsuarios();
        }

        #region HELPER
        private void RefreshdtgUsuarios()
        {
            using (Models.inventarioEntities db = new Models.inventarioEntities())
            {
                var lst = from user in db.usuarios
                          select new { user.nombres, user.apellido, user.usuario, user.roles.rol, user.fechaCreacion, user.estado };
                dgvUsuarios.DataSource = lst.ToList();
            }
        }
        #endregion
    }
}
