namespace Library
{
    class Program 
    {
        public static void Main(string[] args)
        {
            var author = new Author("James Clear", "English");
            var book = new Book("Atomic Habits", author, 9791162540640, EStatus.Disponivel);

            var b = new Library();
            b.AddLibraryBook(book);
            foreach (var item in b.AvailableBooks)
            {
                Console.WriteLine(item);
            }                      
        }
    }
}