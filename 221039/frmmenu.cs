using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _221039.models;
using _221039.views;

namespace _221039
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            Banco.criarbanco();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcidades form = new frmcidades();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmmarca form = new frmmarca();
            form.Show();    

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategoria form = new frmcategoria();
            form.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro form = new Cadastro();
            form.Show();
        }
    }
}
