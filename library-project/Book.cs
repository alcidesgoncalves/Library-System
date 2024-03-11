
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
        public long Isbn;
        public EStatus Status;

        public Book(string title, Author author, long isbn, EStatus status)
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

        public EStatus BorrowBook()
        {
            //alterar status de disponibilidade para EStatus.Emprestado
            Status = EStatus.Emprestado;
            return Status;
        }

        public EStatus ReturnBook()
        {
            //alterar status de disponibilidade para EStatus.Disponivel
            Status = EStatus.Disponivel;
            return Status;
        }

        public EStatus ReserveBook()
        {
            //alterar status de disponibilidade para EStatus.Reservado
            Status = EStatus.Reservado;
            return Status;
        }
    }
}