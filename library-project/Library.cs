namespace Library
{
    public class Library
    {
        //propriedades para armazenar listas de livros disponíveis, livros emprestados*, autores.
        public List<Author> AuthorList {get; set;}  
        public List<Book> AvailableBooks {get; set;}
        public List<Book> BorrowBooks {get; set;}

        public Library() // CONSTRUTOR 
        {
            AvailableBooks = new List<Book>();
            BorrowBooks = new List<Book>();
            AuthorList = new List<Author>();
        }

        public void AddLibraryBook(Book book)
        {
            AvailableBooks.Add(book);
        }

        public List<Author> ListarAutores()
        {
            List<Author> autores = new List<Author>();

            foreach(var book in AvailableBooks)
            {
                if(!autores.Contains(book.Author))
                {
                    autores.Add(book.Author);
                }
            }
            return autores; 
        }

        public void BorrowBook(Book book)
        {
            if(book.BorrowBook(this) == EStatus.Emprestado)
            {
                BorrowBooks.Add(book);
            }
        }

        public void ReturnBook(Book book)
        {
            if(book.ReturnBook() == EStatus.Disponivel)
            {
                BorrowBooks.Remove(book);
            }
        }
    }
}