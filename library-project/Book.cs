
namespace Library
{
    public enum EStatus
    {
        Emprestado = 1,
        Disponivel = 2,
        Reservado = 3
    }

    public class Book
    {
        public string Title {get; set;}
        public Author Author {get; set;}
        public int Isbn;
        public EStatus Status;

        public Book(string title, Author author, int isbn, EStatus status)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Title}, {Author.Name}, {Isbn}, {Status}";
        }

        //Métodos Emprestar livro, Devolver livro e Reservar livro.
        public void BorrowBook()
        {
            //alterar status de disponibilidade para EStatus.Emprestado
        }

        public void ReturnBook()
        {
            //alterar status de disponibilidade para EStatus.Disponivel
        }

        public void ReserveBook()
        {
            //alterar status de disponibilidade para EStatus.Reservado
        }
    }
}