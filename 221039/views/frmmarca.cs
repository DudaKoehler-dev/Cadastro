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

namespace _221039.models
{
    public partial class frmmarca : Form
    {
        Marca m;
        public frmmarca()
        {
            InitializeComponent();
        }

        void limpacontroles()
        {
            txtID.Clear();
            txtmarca.Clear();
            txtPesquisa.Clear();

        }

        void carregarGrid(string pesquisa)
        {
            m = new Marca()
            {
                marca = pesquisa
            };
            dgvmarca.DataSource = m.consultar();
        }

        private void frmmarca_Load(object sender, EventArgs e)
        {
            limpacontroles();
            carregarGrid("");
        }
        
      
        private void btnincluir_Click_1(object sender, EventArgs e)
        {
            if (txtmarca.Text == string.Empty) return;

            m = new Marca()
            {
                marca = txtmarca.Text,

            };
            m.Incluir();
            limpacontroles();
            carregarGrid("");
        }

        private void btbalterar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            m = new Marca()
            {
                marca = txtmarca.Text,
                id = int.Parse(txtID.Text),
               
            };
            m.Alterar();
            limpacontroles();
            carregarGrid("");
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            limpacontroles();
            carregarGrid("");
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    id = int.Parse(txtID.Text),
                };
                m.Excluir();
                limpacontroles();
                carregarGrid("");
            }
        }

        private void btnfechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnpesquisa_Click_1(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void dgvmarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvmarca.RowCount > 0)
            {
                txtID.Text = dgvmarca.CurrentRow.Cells["id"].Value.ToString();
                txtmarca.Text = dgvmarca.CurrentRow.Cells["marca"].Value.ToString();
                
            }
        }
    }
}
