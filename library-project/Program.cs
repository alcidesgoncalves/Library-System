namespace Library
{
    class Program 
    {
        public static void Main(string[] args)
        {
            var author = new Author("James Clear", "English");
            var author2 = new Author("Ali Hazelwood", "English");

            var book1 = new Book("Atomic Habits", author, 9791162540640, EStatus.Disponivel);
            var book2 = new Book("Bride", author2, 8881162540640, EStatus.Emprestado);

            var b = new Library();
            b.AddLibraryBook(book1);
            b.AddLibraryBook(book2);
            
            b.BorrowBook(book1);
            b.ReturnBook(book2);
        }
    }
}