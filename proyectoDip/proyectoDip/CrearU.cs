using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    public partial class CrearU : Form
    {
         Grupo[] grupos = new Grupo[200];
         Usuario[] users = new Usuario[999];
        public CrearU()
        {
            InitializeComponent();
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.setId(txtId.Text);
            user.setCargo(txtCargo.Text);
            user.setGrupo(txtGrupo.Text);
            user.setContra(txtContra.Text);
         

            for (int i = 0; i < 999; i++)
            {
                if (users[i] == null)
                {
                    users[i] = user;
                }
                break;
            }
            Form1 f1 = new Form1(users);
            f1.Show();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearU_Load(object sender, EventArgs e)
        {

        }
    }
}
