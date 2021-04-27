using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_de_Inventario;
namespace Contro_de_Inventario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using(Models.inventarioEntities db =new Models.inventarioEntities())
            {
                var lst = from d in db.usuarios
                          where d.usuario == txtUser.Text.Trim()
                          && d.contrasena == txtPassword.Text.Trim()
                          select d;

                if (lst.Count()>0)
                {
                    FrmMenu form = new FrmMenu();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña invalida");
                }
             }
        }
    }
}
