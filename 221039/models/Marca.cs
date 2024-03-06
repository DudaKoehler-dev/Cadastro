


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
    internal class Marca
    {
        public int id { get; set; }
        public string marca { get; set; }

        public DataTable consultar()
        {
            try
            {
                Banco.abrirconexao();
                Banco.comando = new MySqlCommand("USE VENDAS;SELECT * FROM Marcas where marca like @Marca" +
                    " order by marca", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@Marca", marca + "%");
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
                Banco.comando = new MySqlCommand("USE VENDAS;INSERT INTO Marcas (marca) VALUES (@Marca)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@Marca", marca);
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
                Banco.comando = new MySqlCommand("USE VENDAS;Update Marcas set marca = @Marca where id=@id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.Parameters.AddWithValue("@Marca", marca);
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
                Banco.comando = new MySqlCommand("USE VENDAS;delete from Marcas where id = @id", Banco.conexao);
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