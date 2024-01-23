
namespace Library
{
    public class Book
    {
        public string Title {get; set;}
        public Author Author {get; set;}
        public int Isbn;
        public bool Status;

        public Book(string title, Author author, int isbn, bool status)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Title}, {Author}, {Isbn}, {Status}";
        }

        //Métodos Emprestar livro, Devolver livro e Reservar livro.
    }
}