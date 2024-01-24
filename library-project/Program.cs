namespace Library
{
    class Program 
    {
        public static void Main(string[] args)
        {
            var author = new Author("James Clear", "English", new DateTime(1986, 12, 16));
            Console.WriteLine(author);

            author.AddBook("Atomic Habits", 9791162540640, EStatus.Disponivel);
            foreach (var book in author.Books)
            {                
                Console.WriteLine(book);
            }
        }
    }
}