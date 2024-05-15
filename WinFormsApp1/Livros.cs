using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp1;


namespace WinFormsApp1
{
    public class Livros
    {
        public int id { get; set; }
        public string Título { get; set; }
        public string Gênero{ get; set; }

        public string conexao = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Livros;Integrated Security=True; TrustServerCertificate=True";
        public List<Livros> listaLivros()
        {
            List<Livros> listaLivro = new List<Livros>();
            SqlConnection con = new SqlConnection(conexao);
            string selecionar = "select * from livros";
            con.Open();
            SqlCommand cmd = new SqlCommand(selecionar, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Livros livro = new Livros();
                    livro.id = Convert.ToInt32(dr["id"]);
                    livro.Gênero = dr["genero"].ToString();
                    livro.Título = dr["titulo"].ToString();
                    listaLivro.Add(livro);
                }

            }
            return listaLivro;

        }
        public void CriarLivro(Livros livro)
        {
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(null, con);
            cmd.CommandText = ("INSERT INTO livros (titulo, genero) VALUES (@titulo, @genero)");
            cmd.Parameters.Add(new SqlParameter("@titulo", livro.Título));
            cmd.Parameters.Add(new SqlParameter("@genero", livro.Gênero));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void EditarLivro()
        {
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(null, con);
            cmd.CommandText = ("update livros set titulo = @titulo, genero = @genero where id = @id");
            cmd.Parameters.Add(new SqlParameter("@id", this.id));
            cmd.Parameters.Add(new SqlParameter("@titulo", this.Título));
            cmd.Parameters.Add(new SqlParameter("@genero", this.Gênero));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ExcluirLivro(int idlivro)
        {
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(null, con);
            cmd.CommandText = "delete livros where id = @id";
            cmd.Parameters.Add(new SqlParameter("@id", idlivro));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    } }
