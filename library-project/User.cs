namespace Library
{
    public class User
    {
        public required string Name;
        public required int UserId;
        public List<string>? BorrowedBooks;
        public List<string>? BorrowHistory;
        // Métodos: Realizar Empréstimo, Devolver Livro, Reservar Livro.
    }
}