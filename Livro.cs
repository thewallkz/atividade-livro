using System.Diagnostics.Contracts;

namespace atividade_livro
{
    public class Livro
    {
        private string titulo { get; set; }
        private string autor { get; set; }
        private int numeroDePaginas { get; set; }
        private bool emprestado { get; set; }

        public Livro(string titulo, string autor, int numeroDePaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numeroDePaginas = numeroDePaginas;
            this.emprestado = false;
        }

        public void emprestar()
        {
            this.emprestado = true;
            System.Console.WriteLine("Livro emprestado");
        }
        public void devolver()
        {
            this.emprestado = false;
            System.Console.WriteLine("Livro devolvido");
        }

        public string status()
        {
            if (this.emprestado)
            {
                return "Livro emprestado";
            }
            else
            {
                return "Livro disponivel";
            }
        }
        public void setNumeroDePaginas(int paginas)
        {
            if (paginas <= 0)
            {
                throw new ArgumentException("Numero de paginas invalido!");
            }
            this.numeroDePaginas = paginas;
        }

        public void imprimirDados()
        {
            System.Console.WriteLine($"Titulo: {this.titulo}\nAutor: {this.autor}\tPaginas: {this.numeroDePaginas}");
        }
    }
}