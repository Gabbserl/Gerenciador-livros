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
    public partial class Form3 : Form
    {
        int idlivro;
        public Form3()
        {
            InitializeComponent();
        }

        private void botaoOk_Click(object sender, EventArgs e)
        {
            Livros livro = new Livros() ;
            livro.EditarLivro(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}