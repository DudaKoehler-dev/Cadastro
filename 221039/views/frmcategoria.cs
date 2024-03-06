using _221039.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221039.views
{
    public partial class frmcategoria : Form
    {
        Categoria cat;
        public frmcategoria()
        {
            InitializeComponent();
        }
        void limpacontroles()
        {
            txtID.Clear();
            txtcategoria.Clear();
            txtPesquisa.Clear();

        }
        void carregarGrid(string pesquisa)
        {
            cat = new Categoria()
            {
                categoria = pesquisa
            };
            dgvcategoria.DataSource = cat.consultar();
        }

        private void frmcategoria_Load(object sender, EventArgs e)
        {
            limpacontroles();
            carregarGrid("");
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            if (txtcategoria.Text == string.Empty) return;

            cat = new Categoria()
            {
                categoria = txtcategoria.Text,

            };
            cat.Incluir();
            limpacontroles();
            carregarGrid("");
        }

        private void btbalterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            cat = new Categoria()
            {
                categoria = txtcategoria.Text,
                id = int.Parse(txtID.Text),

            };
            cat.Alterar();
            limpacontroles();
            carregarGrid("");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpacontroles();
            carregarGrid("");
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cat = new Categoria()
                {
                    id = int.Parse(txtID.Text),
                };
                cat.Excluir();
                limpacontroles();
                carregarGrid("");
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void dgvcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcategoria.RowCount > 0)
            {
                txtID.Text = dgvcategoria.CurrentRow.Cells["id"].Value.ToString();
                txtcategoria.Text = dgvcategoria.CurrentRow.Cells["categoria"].Value.ToString();

            }
        }
    }
}
