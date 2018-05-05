using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RamboErp.dao;
using System.Web.UI.HtmlControls;

namespace RamboErp
{
    public partial class ListarPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            geraTabela();
        }

        private void geraTabela()
        {
            HtmlTable tabela = new HtmlTable();
            HtmlTableRow linha;
            HtmlTableCell coluna;
           // string[] campos = { "Código", "Nome", "Tipo", "Endereço", "Cidade", "Cep", "Uf", "Cnpj-Cpf", "Data Nascimento" };
            PessoaDao pessoaDao = new PessoaDao();
            int numero = pessoaDao.buscarPessoas().Length;

            for (int i = 0; i < numero; i++)
            {
                linha = new HtmlTableRow();
               
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getId());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getName());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getTypePerson());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getAddress());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getCity());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getCep());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getState());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getCnpj_cpf());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getDateOfBirth());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = "<a href='Cadastro.aspx?id="+Convert.ToString(pessoaDao.buscarPessoas()[i].getId())+"'>Alterar</a>";
                    linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);

            }
            Controls.Add(tabela);
        }
    }
}