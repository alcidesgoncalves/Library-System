namespace Library
{
    class Program 
    {
        public static void Main(string[] args)
        {
            var book = new Book("", "", 315, true) {Title = "Atomic Habits", Author = "Frederico" };
            Console.WriteLine(book);
        }
    }
}