namespace Library
{
    class Program 
    {
        public static void Main(string[] args)
        {
            var author = new Author("James Clear", "English", new DateTime(1986, 12, 16));
            Console.WriteLine(author);

            author.AddBook("Atomic Habits", 9791162540640, EStatus.Disponivel);
            foreach (var book in author.Books)
            {                
                Console.WriteLine(book);
            }
            
            var user = new User("Alcides Neto", 1);

            var book1 = new Book("Odisseia no Espaço", new Author("Mario Oliveira", "English", new DateTime(1986, 12, 16)) ,9791162540640, EStatus.Disponivel);
            var book2 = new Book("Viagem ao Espaço", new Author("Maria Oliveira", "English", new DateTime(1986, 12, 16)), 9876543210, EStatus.Disponivel);

            user.RealizarEmprestimo(book1);
            user.RealizarEmprestimo(book2);

            user.DevolverLivro(book1);

            user.ReservarLivro(book2);

            Console.WriteLine("Estado atual do usuário: ");
            Console.WriteLine($"Nome: {user.Name}, ID: {user.ID}");
            Console.WriteLine("Livros emprestados: ");
            
            foreach (var livroEmprestado in user.BorrowedBooks)
            {
                Console.WriteLine($"- {livroEmprestado.Title}");
            }
            Console.WriteLine("Histórico de empréstimos:");
            foreach (var historico in user.BorrowHistory)
            {
                Console.WriteLine($"- {historico.Title}");
            }

        }
    }
}