using System.Data.SqlClient;
using System.IO;

namespace PdfSalvarRecuperarCSharp
{
    internal class Livros
    {
        private string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Livros;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int Id { get; set; }
        public string Titulo { get; set; }
        public byte[] Pdf { get; set; }


        public void Get(int id, Livros livros)
        {
            var sql = "SELECT titulo, pdf FROM Livros WHERE id =" + id;

            using (var con = new SqlConnection(strCon))
            {

                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {

                        if (dr.HasRows)
                        {

                            if (dr.Read())
                            {
                                livros.Id = id;
                                livros.Titulo = dr["titulo"].ToString();
                                livros.Pdf = (byte[])dr["pdf"];
                            }
                        }
                    }
                }
            }
        }

        public void Salvar(Livros livro, string caminhoPdf)
        {
            byte[] pdf = GetPdf(caminhoPdf);

            var sql = "INSERT INTO [Livros].[dbo].[Livros] (titulo, pdf) VALUES (@titulo, @pdf)";
            using (var con = new SqlConnection(strCon))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
                    cmd.Parameters.Add("@pdf", System.Data.SqlDbType.VarBinary, pdf.Length).Value = pdf;

                    cmd.ExecuteNonQuery();
                }
            }

        }
        private byte[] GetPdf(string caminhoPdf)
        {
            byte[] pdf;

            using (var stream = new FileStream(caminhoPdf, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    pdf = reader.ReadBytes((int)stream.Length);
                }
            }
            return pdf;

        }


    }
}
