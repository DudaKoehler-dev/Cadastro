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

namespace _221039.views
{
    public partial class Cadastro : Form
    {
        Cidade ci;
        Cliente cl;
        public Cadastro()
        {
            InitializeComponent();
        }
        void limpacontroles()
        {
            txtID.Clear();
            txtnome.Clear();
            cbocidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtrenda.Clear();
            dateTimePicker1.Value = DateTime.Now;
            picfoto.ImageLocation = "";
            chkvenda.Checked = false;
        }
        void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };
            dgvclientes.DataSource = cl.Consultar();
        }
        private void frmcliente_Load(object sender, EventArgs e)
        {
            ci =  new Cidade();
            cbocidades.DataSource = ci.consultar();
            cbocidades.DisplayMember = "nome";
            cbocidades.ValueMember= "id";

            limpacontroles();
            carregarGrid("");

            dgvclientes.Columns["idcidade"].Visible = false;
            dgvclientes.Columns["foto"].Visible = true;
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "") return;

            cl = new Cliente()
            {
                nome = txtnome.Text,
                idcidade = (int)cbocidades.SelectedValue,
                datanasc = dateTimePicker1.Value,
                renda = double.Parse(txtrenda.Text),
                cpf = mskCPF.Text,
                foto = picfoto.ImageLocation,
                venda = chkvenda.Checked
            };
            cl.Incluir();
            limpacontroles();
            carregarGrid("");
        }

        private void btbalterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            cl = new Cliente()
            {
                id = int.Parse(txtID.Text),
                nome = txtnome.Text,
                idcidade = (int)cbocidades.SelectedValue,
                datanasc = dateTimePicker1.Value,
                renda = double.Parse(txtrenda.Text),
                cpf = mskCPF.Text,
                foto = picfoto.ImageLocation,
                venda = chkvenda.Checked
            };
            cl.Alterar();
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
             
             if (MessageBox.Show ("Deseja excluir o cliente?", "Exclusão",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                cl = new Cliente()
                {
                    id = int.Parse(txtID.Text)
                };
                cl.Excluir();
                limpacontroles();
                carregarGrid("");
            }
           
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picfoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:/fotos/clientes/";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            picfoto.ImageLocation = openFileDialog1.FileName;
        }

        private void cbocidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbocidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cbocidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvclientes.CurrentRow.Cells["id"].Value.ToString();
            txtnome.Text = dgvclientes.CurrentRow.Cells["nome"].Value.ToString();
            cbocidades.Text = dgvclientes.CurrentRow.Cells["cidade"].Value.ToString();
            txtUF.Text = dgvclientes.CurrentRow.Cells["uf"].Value.ToString();
            chkvenda.Checked = (bool)dgvclientes.CurrentRow.Cells["venda"].Value;
            mskCPF.Text = dgvclientes.CurrentRow.Cells["cpf"].Value.ToString();
            dateTimePicker1.Text = dgvclientes.CurrentRow.Cells["datanasc"].Value.ToString();
            txtrenda.Text = dgvclientes.CurrentRow.Cells["renda"].Value.ToString();
            picfoto.ImageLocation = dgvclientes.CurrentRow.Cells["foto"].Value.ToString();
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvclientes.CurrentRow.Cells["id"].Value.ToString();
            txtnome.Text = dgvclientes.CurrentRow.Cells["nome"].Value.ToString();
            cbocidades.Text = dgvclientes.CurrentRow.Cells["cidade"].Value.ToString();
            txtUF.Text = dgvclientes.CurrentRow.Cells["uf"].Value.ToString();
            chkvenda.Checked = (bool)dgvclientes.CurrentRow.Cells["venda"].Value;
            mskCPF.Text = dgvclientes.CurrentRow.Cells["cpf"].Value.ToString();
            dateTimePicker1.Text = dgvclientes.CurrentRow.Cells["datanasc"].Value.ToString();
            txtrenda.Text = dgvclientes.CurrentRow.Cells["renda"].Value.ToString();
            picfoto.ImageLocation = dgvclientes.CurrentRow.Cells["foto"].Value.ToString();
        }
    }
    
}
