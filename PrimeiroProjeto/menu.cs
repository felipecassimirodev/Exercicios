using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();



        }

        private void botao_cadastrar_categoria_Click(object sender, EventArgs e)
        {
            frm_categotia categoria = new frm_categotia();
            categoria.Show();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categotia cat = new frm_categotia();
            cat.Show();
        }
    }
}
