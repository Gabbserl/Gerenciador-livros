using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        int idlivro;
        public Form4()

        {
            InitializeComponent();
        }

        private void botaoOk_Click(object sender, EventArgs e)
        {
            Livros livro = new Livros();
            livro.ExcluirLivro(idlivro = int.Parse(textBox1.Text.ToString()));
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
