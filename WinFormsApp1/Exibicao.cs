using WinFormsApp1;
namespace WinFormsApp1
{
    public partial class Exibicao : Form
    {
        public Exibicao()
        {
            InitializeComponent();
            FillGridView();
        }
        void FillGridView()
        {
            List<Livros> listaLivros = new List<Livros>();
            Livros livro = new Livros();
            listaLivros = livro.listaLivros();
            listaExibicao.DataSource = listaLivros;


        }


        private void botaoadicionar_Click(object sender, EventArgs e)
        {
            Adicionar botaoadicionar = new Adicionar();
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
            Livros livro = new Livros();
            if (listaExibicao.CurrentRow != null)
            {
                livro.id = int.Parse(listaExibicao.CurrentRow.Cells[0].Value.ToString());
                livro.Gênero = listaExibicao.CurrentRow.Cells[1].Value.ToString();
                livro.Título = listaExibicao.CurrentRow.Cells[2].Value.ToString();
                Editar editarLivro = new Editar(livro);
                editarLivro.ShowDialog();
            }
        }
        void ExcluirLivro()
        {
            if (listaExibicao.CurrentRow != null)
            {
                int idLivro = int.Parse(listaExibicao.CurrentRow.Cells[0].Value.ToString());
                Livros livro = new Livros();
                livro.ExcluirLivro(idLivro);
                FillGridView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcluirLivro();
        }
    }
}