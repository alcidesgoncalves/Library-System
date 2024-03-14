namespace Library
{
    public class Library
    {
        //propriedades para armazenar listas de livros disponíveis, livros emprestados*, autores e usuários registrados.
        public List<Author> AuthorList {get; set;}  
        public List<Book> AvailableBooks {get; set;}
        public List<Book> BorrowBooks {get; set;}
        public List<User> UserList {get; set;} 

        public Library() // CONSTRUTOR 
        {
            AvailableBooks = new List<Book>();
            BorrowBooks = new List<Book>();
            UserList = new List<User>();
        }

        public List<Author> ListarAutores()
        {
            List<Author> autores = new List<Author>();

            foreach(var book in AvailableBooks)
            {
                if(!autores.Contains(book.Author))
                {
                    autores.Add(book.Author)
                }
            }

            return autores; 
        }
        
    }
}