using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TesteConexaoBanco
{
    internal class Conexao
    {
        //    private static string Servidor = "localhost";
        //    private static string Banco = "bd_teste";
        //    private static string Usuario = "root";
        //    private static string Senha = "felipe123";
        //    public static string strCON = $"server ={Servidor};" +
        //    $"database={Banco};User Id ={Usuario}" + $"password ={Senha}";

       public static string strCON = "Server =localhost;database=bd_teste; User id= root;pwd=felipe123";
      
        bool Retorno_conexao = false;
       
        MySqlConnection conexao_banco;
         private bool Conectar_banco()
        {
            try
            {
                conexao_banco = new MySqlConnection(strCON);
                conexao_banco.Open();
            }
            catch (Exception ex)
            {

             MessageBox.Show(ex.Message);
            }
            return Retorno_conexao;


        }

        private bool Desconectar_banco()
        {
            if (conexao_banco.State== System.Data.ConnectionState.Open)
            {
                conexao_banco.Close();
            }
            return Retorno_conexao;

        }
        public bool Executar_sql(string sql)
        { 
            Conectar_banco();
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conexao_banco);
                cmd.ExecuteNonQuery();
               Retorno_conexao=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Retorno_conexao = false;
                

            }
            finally
            {
                Desconectar_banco();
            }
            return Retorno_conexao;
        }
        public DataTable retorno_tabela(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conexao_banco);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }
    }
}
