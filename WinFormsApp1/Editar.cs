using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Editar : Form
    {
        int idAlterar;
        public Editar(Livros livro)
        {
            InitializeComponent();
            idAlterar = livro.id;
            tituloTxt.Text = livro.Título;
            generoTxt.Text = livro.Gênero;

        }

        private void botaoOk_Click(object sender, EventArgs e)
        {
            Livros livro = new Livros();
            livro.id = idAlterar;
            livro.Título = tituloTxt.Text;
            livro.Gênero = generoTxt.Text;
            livro.EditarLivro();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}