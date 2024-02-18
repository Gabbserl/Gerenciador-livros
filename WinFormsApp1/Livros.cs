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
    internal class Livros
    {
        public int id { get; set; }
        public string Gênero { get; set; }
        public string Título { get; set; }

        public string conexao = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Livros;Integrated Security=True; TrustServerCertificate=True";
        public List<Livros> listaLivros()
        {
            List<Livros> listaLivro = new List<Livros>();
            SqlConnection con = new SqlConnection(conexao);
            string selecionar = "select id, genero, titulo from verlivros";
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
            SqlCommand cmd = new SqlCommand("criarlivro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", livro.id));
            cmd.Parameters.Add(new SqlParameter("@titulo", livro.Título));
            cmd.Parameters.Add(new SqlParameter("@genero", livro.Gênero));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void EditarLivro(int idlivro, string titulo, string genero)
        {
            string conexao = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Livros;Integrated Security=True; TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update livros set titulo = '" + titulo + "', genero = '" + genero + "' where id = '" + idlivro + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ExcluirLivro(int idlivro)
        {
            string conexao = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Livros;Integrated Security=True; TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete livros where id = '" + idlivro + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    } }
