using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RamboErp.Entidades;
using System.Data;
using System.Data.SqlClient;

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


        public void excluir(Pessoa pessoa)
        {
            conexao.abreConexao();
            conexao.executarComando("DELETE FROM PESSOA WHERE ID_EMPRESA='"+pessoa.getId()+"'");
            conexao.encerraConexao();
        }

        public String buscaDados()
        {
            string tabela = "<table>";
            conexao.abreConexao();
            String sql = "select * from Pessoa";

            SqlDataReader ler = conexao.listar(sql);

            tabela = "<table><thead><tr><th>Nome Completo</th><th>Tipo Pessoa</th><th>Endereço</th><th>Cidade</th><th>CEP</th><th>UF</th><th>CNPJ/CPF</th><th>Data Nascimento</th></tr></thead><tbody>";


            while (ler.Read())
            {
                tabela += "<tr>";
                tabela += "<td>" + ler["Nome_Completo"] + "</td><td>" + ler["TP_Pessoa"] + "</td><td>" + ler["Endereco"] + "</td><td>" + ler["Cidade"] + "</td><td>" + ler["CEP"] + "</td><td>" + ler["UF"] + "</td><td>" + ler["CNPJ_CPF"] + "</td><td>" + ler["Data_Nascimento"];
                tabela += "<td><button value='"+ler["ID_EMPRESA"]+"'Editar</td>";
                tabela += "</tr>";
            }

            conexao.encerraConexao();
            return tabela;     
        }


        public Pessoa buscaPessoaPorId(int id)
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