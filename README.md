# atividade-livro
Crie uma classe com o nome Livro que possua os seguintes atributos:
String titulo: Título do livro.
String autor: Autor do livro.
int numeroDePaginas: Número total de páginas do livro.
boolean emprestado: Indica se o livro está emprestado ou não.
A classe deve ter os seguintes métodos:
void emprestar(): Marca o livro como emprestado (atributo emprestado deve ser true) e exibe a mensagem "Livro emprestado".void devolver(): Marca o livro como devolvido (atributo emprestado deve ser false) e exibe a mensagem "Livro devolvido".String status(): Retorna o status atual do livro. Se o livro estiver emprestado, deve exibir "Livro emprestado", caso contrário, "Livro disponível".void setNumeroDePaginas(int paginas): Altera o número de páginas do livro. Se o número for menor ou igual a 0, o método deve exibir a mensagem "Número de páginas inválido".
Além disso, aplique encapsulamento nos atributos da classe, garantindo que os valores dos atributos sejam acessados ou modificados apenas através dos métodos da classe.
