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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botaoOk_Click(object sender, EventArgs e)
        {
            SalvarLivros();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SalvarLivros()
        {
            Livros livro = new Livros();
            livro.Título = textBox2.Text;
            livro.id = int.Parse(textBox1.Text);
            livro.Gênero = textBox3.Text;
            livro.CriarLivro(livro);
        }
    }
}
