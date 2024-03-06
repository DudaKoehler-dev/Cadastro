using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221039
{
    public class Banco
    {
        public static MySqlConnection conexao;
        public static MySqlCommand comando;
        public static MySqlDataAdapter adaptador;
        public static DataTable datTabela;

        public static void abrirconexao()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                conexao.Open();
            }
            catch (Exception e)
            { 
                MessageBox.Show(e.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public static void fecharconexao()
        {
            try
            {
                conexao.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void criarbanco()
        {
            try
            {
                abrirconexao();
                comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas;", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE  IF NOT EXISTS Cidades" +
                    "(id integer auto_increment primary key," +
                    "nome char(40)," +
                    "uf char(02));", conexao);
                 
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE  IF NOT EXISTS Marcas" +
                    "(id integer auto_increment primary key," +
                    "marca char(40));", conexao);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE  IF NOT EXISTS Categorias" +
                    "(id integer auto_increment primary key," +
                    "categoria char(40));", conexao);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE  IF NOT EXISTS Clientes(" +
                 "id integer auto_increment primary key," +
                 "nome char(40),"+
                 "idcidade integer,"+
                 "datanasc date," +
                 "renda decimal(10,2),"+
                 "cpf char(14),"+
                 "foto varchar(100),"+
                 "venda boolean);", conexao);

                comando.ExecuteNonQuery();

                fecharconexao();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
    
}
