using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _221039.models
{
    internal class Cliente
    {
        public int id {get; set;}
        public string nome { get; set;} 

        public int idcidade { get; set;}

        public DateTime datanasc { get; set;}

        public double renda { get; set;}
        public string cpf { get; set;}
        public string foto { get; set;}
        public bool venda { get; set;}

        public void Incluir()
        {
            try
            {
                Banco.abrirconexao();
                Banco.comando = new MySqlCommand
                     ("USE vendas;INSERT INTO clientes (nome, idcidade, datanasc, renda, cpf,  foto, venda)" +
                     "VALUES (@nome, @idcidade, @datanasc , @renda, @cpf, @foto, @venda)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("@idcidade", idcidade);
                Banco.comando.Parameters.AddWithValue("@datanasc", datanasc);
                Banco.comando.Parameters.AddWithValue("@renda", renda);
                Banco.comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.comando.Parameters.AddWithValue("@foto", foto);
                Banco.comando.Parameters.AddWithValue("@venda", venda);
                Banco.comando.ExecuteNonQuery();
                Banco.fecharconexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
            public void Alterar()
            {

                try
                {
                    Banco.abrirconexao();
                    Banco.comando = new MySqlCommand("USE vendas;Update clientes set nome = @nome, idcidade = @idcidade,datanasc =  @datanasc , renda = @renda, cpf = @cpf, foto = @foto, venda =  @venda" +
                        " where id=@id", Banco.conexao);
                    Banco.comando.Parameters.AddWithValue("@id", id);
                    Banco.comando.Parameters.AddWithValue("@nome", nome);
                    Banco.comando.Parameters.AddWithValue("@idcidade", idcidade);
                    Banco.comando.Parameters.AddWithValue("@datanasc", datanasc);
                    Banco.comando.Parameters.AddWithValue("@renda", renda);
                    Banco.comando.Parameters.AddWithValue("@cpf", cpf);
                    Banco.comando.Parameters.AddWithValue("@foto", foto);
                    Banco.comando.Parameters.AddWithValue("@venda", venda);
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
                        Banco.comando = new MySqlCommand("USE vendas;delete from clientes where id = @id", Banco.conexao);
                        Banco.comando.Parameters.AddWithValue("@id", id);
                        Banco.comando.ExecuteNonQuery();
                        Banco.fecharconexao();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                    public DataTable Consultar()
                    {
                        try
                        {
                            Banco.comando = new MySqlCommand("USE vendas;SELECT cl.*, ci.nome cidade, ci.uf FROM Clientes cl inner join Cidades ci on (ci.id = cl.idcidade)" +
                                "where cl.nome like ?Nome order by cl.nome", Banco.conexao);
                            Banco.comando.Parameters.AddWithValue("@Nome", nome + "%");
                            Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                            Banco.datTabela = new DataTable();
                            Banco.adaptador.Fill(Banco.datTabela);
                            return Banco.datTabela;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                     }
        }
    }

