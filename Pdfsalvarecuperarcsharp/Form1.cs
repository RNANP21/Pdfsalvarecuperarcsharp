using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdfsalvarecuperarcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregarPdf_Click(object sender, EventArgs e)
        {
            lblArquivoPdf.Text = GetPdf();
        }
        private string GetPdf()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos PDFs |*.pdf";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                return openFile.FileName;
            else
                return "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarLivro();
        }
        private void SalvarLivro()
        {
            Livros livro = new Livros();

            livro.Titulo = txtTitulo.Text;
            livro.Salvar(livro, lblArquivoPdf.Text,
                    cmd);

            MessageBox.Show("Livro salvo com sucesso");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtId.Text);
            CarregarPdf(id);
        }
        private void CarregarPdf(int id)
        {
          var destino = "c:\\dados\\meuArquivo.pdf";
          Livros livro = new Livros();
          livro.Get(id, livro);

            txtTitulo.Text = livro.Titulo;

            using (var arquivoPdf = new FileStream(destino, FileMode.Create, FileAccess.Write ))
                arquivoPdf.Write(livro.Pdf, 0, livro.Pdf.Length);

            MessageBox.Show("Livro recuperado em:" + destino);

        }
       
        

    }
}
