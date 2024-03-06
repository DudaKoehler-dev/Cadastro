using _221039.models;
using MySql.Data.MySqlClient;
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
    public partial class frmcidades : Form
    {
        Cidade c;
        
        public object uf { get; private set; }
        public object nome { get; private set; }

        public frmcidades()
        {
            InitializeComponent();
        }

        void limpacontroles()
        {
            txtID.Clear();
            txtestado.Clear();
            txtnome.Clear();
            txtPesquisa.Clear();
            
        }
        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.consultar();
        }

        private void frmcidades_Load(object sender, EventArgs e)
        {
            limpacontroles();
            carregarGrid("");
        }

       

        private void btnincluir_Click(object sender, EventArgs e)
        {
           if (txtnome.Text == string.Empty) return; 

            c = new Cidade()
            {
                nome = txtnome.Text,
                uf = txtestado.Text,
            };
            c.Incluir();
            limpacontroles();
            carregarGrid("");
        }

        private void dvgcidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                txtID.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();    
                txtnome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtestado.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btbalterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            c = new Cidade()
            {
                nome = txtnome.Text,
                id = int.Parse(txtID.Text),
                uf = txtestado.Text
            };
            c.Alterar();
            limpacontroles();
            carregarGrid("");
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return; 

            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    id = int.Parse(txtID.Text),
                };
                c.Excluir();
                limpacontroles();
                carregarGrid("");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpacontroles();
            carregarGrid("");
        }
        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }
        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
