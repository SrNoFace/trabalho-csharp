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

        }

        private void geraTabela()
        {
            HtmlTable tabela = new HtmlTable();
            HtmlTableRow linha;
            HtmlTableCell coluna;
            PessoaDao pessoaDao = new PessoaDao();
            int numero = pessoaDao.buscarPessoas().Length;

            for (int i = 0; i < numero; i++)
            {
                linha = new HtmlTableRow();
                for (int z = 0; z < 9; z++)
                {
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = pessoaDao.buscarPessoas()[z].ToString();
                    linha.Cells.Add(coluna);
                }
                tabela.Rows.Add(linha);

            }
            Controls.Add(tabela);
        }
    }
}