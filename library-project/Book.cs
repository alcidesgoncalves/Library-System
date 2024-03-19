
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
        public Library BorrowedFromLibrary {get; set;}

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

        public EStatus BorrowBook(Library library)
        {
            //alterar status de disponibilidade para EStatus.Emprestado
            if (Status == EStatus.Disponivel)
            {
                Status = EStatus.Emprestado;
                BorrowedFromLibrary = library;
                return Status;
            }
            else
            {
                Console.WriteLine("O livro não está disponível para empréstimo.");
                return Status;
            }
        }

        public EStatus ReturnBook()
        {
            //alterar status de disponibilidade para EStatus.Disponivel
            if (Status == EStatus.Emprestado)
            {
                Status = EStatus.Disponivel;
                BorrowedFromLibrary = null;
                return Status;
            }
            else
            {
                Console.WriteLine("O livro não foi emprestado.");
                return Status;
            }
        }

        public EStatus ReserveBook()
        {
            //alterar status de disponibilidade para EStatus.Reservado
            Status = EStatus.Reservado;
            return Status;
        }
    }
}