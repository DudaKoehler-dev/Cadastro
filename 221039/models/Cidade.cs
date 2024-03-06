using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _221039.models
{
    internal class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }

        public string uf { get; set; }

        

        public DataTable consultar()
        {
            try
            {
                Banco.abrirconexao();
                Banco.comando = new MySqlCommand("USE VENDAS;SELECT * FROM Cidades where nome like @nome " +
                    "order by nome", Banco.conexao);

                Banco.comando.Parameters. AddWithValue("@nome", nome + "%");
                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datTabela = new DataTable();
                Banco.adaptador.Fill(Banco.datTabela);
                Banco.fecharconexao();
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Incluir()
        {
            try
            {
                Banco.abrirconexao();
                Banco.comando = new MySqlCommand("USE VENDAS;INSERT INTO cidades (nome,uf) VALUES (@nome,@uf)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("@uf", uf);
                Banco.comando.ExecuteNonQuery();
                Banco.fecharconexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    public void Alterar()
    {
        try
        {
            Banco.abrirconexao();
            Banco.comando = new MySqlCommand("USE VENDAS;Update cidades set nome = @nome, uf = @uf where id=@id", Banco.conexao);
            Banco.comando.Parameters.AddWithValue("@nome", nome);
            Banco.comando.Parameters.AddWithValue("@uf", uf);
            Banco.comando.Parameters.AddWithValue("@id", id);
            Banco.comando.ExecuteNonQuery();
            Banco.fecharconexao();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

        public void Excluir()
        {
            try
            {
                Banco.abrirconexao();
                Banco.comando = new MySqlCommand("USE VENDAS;delete from cidades where id = @id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.ExecuteNonQuery();
                Banco.fecharconexao();

            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}