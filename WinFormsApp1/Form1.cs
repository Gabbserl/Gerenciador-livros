using WinFormsApp1;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillGridView();
        }
        void FillGridView()
        {
            List<Livros> listaLivros = new List<Livros>();
            Livros livro = new Livros();
            listaLivros = livro.listaLivros();
            dataGridView1.DataSource = listaLivros;


        }


        private void botaoadicionar_Click(object sender, EventArgs e)
        {
            Form2 botaoadicionar = new Form2();
            botaoadicionar.ShowDialog();
        }

        private void form1_activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarLivro();
        }
        void EditarLivro()
        {
            Form3 editarLivro = new Form3();
            editarLivro.ShowDialog();
        }
        void ExcluirLivro()
        {
            Form4 excluirLivro = new Form4();
            excluirLivro.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcluirLivro();
        }
    }
}