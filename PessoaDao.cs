using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RamboErp.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace RamboErp.dao
{
    public class PessoaDao
    {
        private Conexao conexao = new Conexao();

        public void inserir(Pessoa pessoa)
        {
            conexao.abreConexao();         
            String sql = "INSERT INTO PESSOA(NOME_COMPLETO, TP_PESSOA, ENDERECO, CIDADE, CEP, UF, CNPJ_CPF, DATA_NASCIMENTO)";
            sql += "VALUES ('"+pessoa.getName()+"', '"+pessoa.getTypePerson()+"', '"+pessoa.getAddress()+"','" +pessoa.getCity()+"', '"+pessoa.getCep()+"','"+pessoa.getState()+"','"+pessoa.getCnpj_cpf()+"','"+pessoa.getDateOfBirth()+"')";
            conexao.executarComando(sql);
            conexao.encerraConexao();
         
        }

        public void alterar(Pessoa pessoa)
        {
            conexao.abreConexao();
            String sql = "UPDATE PESSOA SET NOME_COMPLETO = '"+pessoa.getName()+"', TP_PESSOA = '"+pessoa.getTypePerson()+"', ENDERECO = '"+pessoa.getAddress()+"' WHERE ID_EMPRESA = '"+pessoa.getId()+"'";
            conexao.executarComando(sql);
            conexao.encerraConexao();
        }


        public void excluir(Pessoa pessoa)
        {
            conexao.abreConexao();
            conexao.executarComando("DELETE FROM PESSOA WHERE ID_EMPRESA='"+pessoa.getId()+"'");
            conexao.encerraConexao();
        }

        public void excluir(string id)
        {
            conexao.abreConexao();
            conexao.executarComando("DELETE FROM PESSOA WHERE ID_EMPRESA='" + id + "'");
            conexao.encerraConexao();
        }
      
        public List<Pessoa> buscarPessoas()
        {
            conexao.abreConexao();
  
            string sql = "select * from Pessoa";
            SqlDataReader ler = conexao.listar(sql);
            List <Pessoa>pessoas = new List<Pessoa>();
            while(ler.Read())
            {
            int codigo = Convert.ToInt16(ler["ID_EMPRESA"]);
            string nome = ler["NOME_COMPLETO"].ToString();
            char tipo = Convert.ToChar(ler["TP_Pessoa"]);
            string endereco = ler["Endereco"].ToString();
            string cidade = ler["Cidade"].ToString();
            string cep = ler["Cep"].ToString();
            string uf = ler["Uf"].ToString();
            string cp = ler["CNPJ_CPF"].ToString();
            string data = ler["Data_Nascimento"].ToString();
            pessoas.Add(new Pessoa(codigo, nome, tipo, endereco, cidade, cep, uf, cp, data));
            
            }
            conexao.encerraConexao();
            return pessoas;
        }


        public Pessoa buscaPessoaPorId(String id)
        {
            String sql = "select * from Pessoa Where ID_EMPRESA = '"+id+"'";
            conexao.abreConexao();
            SqlDataReader ler = conexao.listar(sql);
            ler.Read();
            int codigo = Convert.ToInt16(ler["ID_EMPRESA"]);
            string nome = ler["NOME_COMPLETO"].ToString();
            char tipo = Convert.ToChar(ler["TP_Pessoa"]);
            string endereco = ler["Endereco"].ToString();
            string cidade = ler["Cidade"].ToString();
            string cep = ler["Cep"].ToString();
            string uf = ler["Uf"].ToString();
            string cp = ler["CNPJ_CPF"].ToString();
            string data = ler["Data_Nascimento"].ToString();
            Pessoa pessoa = new Pessoa(codigo, nome, tipo,endereco , cidade, cep, uf,cep , data);           
            conexao.encerraConexao();
            return pessoa;
        }
    }
}