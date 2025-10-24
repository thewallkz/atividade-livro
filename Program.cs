using atividade_livro;

Livro livro = new Livro("Dom Casmurro", "Machado de Assis", 10);

livro.emprestar();
livro.devolver();
livro.setNumeroDePaginas(0);

System.Console.WriteLine(livro.status());
livro.imprimirDados();