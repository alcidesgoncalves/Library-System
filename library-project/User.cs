namespace Library
{
    public class User
    {
        public string Name;
        public int ID; 
        public List<Book> BorrowedBooks;
        public List<Book> BorrowHistory;
        // Métodos: Realizar Empréstimo, Devolver Livro, Reservar Livro.
        public User(string name, int id)
        {
            Name = name;
            ID = id; 
            BorrowedBooks = new List<Book>();
            BorrowHistory = new List<Book>();
        }

        public override string ToString()
        {
            return $"Nome do usuário: {Name}, ID do usuário: {ID}";
        }

        public EStatus RealizarEmprestimo(Book book)
        {
            if (book.Status == EStatus.Disponivel)
            {
                BorrowedBooks.Add(book);
                book.BorrowBook();
                return book.Status;
            }
            else
            {
                Console.WriteLine("O livro não está disponível para empréstimo.");
                return EStatus.Disponivel;
            }
        }

        public EStatus DevolverLivro(Book book)
        {
            bool LivroEncontrado = false; 
            foreach (var BorrowedBook in BorrowedBooks)
            {
                if(BorrowedBook.Equals(book))
                {
                    BorrowedBooks.Remove(BorrowedBook);
                    book.ReturnBook();
                    BorrowHistory.Add(book);
                    LivroEncontrado = true;
                    break;
                }
            }
            if (!LivroEncontrado)
            {
                Console.WriteLine("Você não possui este livro para devolver");
            }
            return book.Status;
        }

        public EStatus ReservarLivro(Book book)
        {
            book.ReserveBook();
            return book.Status;
        }
    }
}