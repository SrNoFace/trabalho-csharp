using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace RamboErp.dao
{
    public class Conexao
    {
        private const string conexao = "Data Source=MAQ412\\SQLEXPRESS;Initial Catalog=Trabalho;Integrated Security=True";
        private SqlConnection conn = null;

        public void abreConexao()
        {
            conn = new SqlConnection(conexao);
            conn.Open();
        }

        public void executarComando(string stringSql)
        {           
            SqlCommand sql = new SqlCommand(stringSql, conn);
            sql.ExecuteNonQuery();
        }

        public SqlDataReader listar(String stringSql)
        {
            SqlCommand sql = new SqlCommand(stringSql, conn);
            return  sql.ExecuteReader();
        }
        public void encerraConexao()
        {
            if(conn != null)conn.Close();
        }

    
    }
}