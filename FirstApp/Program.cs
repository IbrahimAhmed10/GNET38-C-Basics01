namespace FirstApp
{
    internal class Book
    {
        public string Title { get; private set; }
        public int Pages { get; private set; }

        static void Main(string[] args)
        {
            //q1
            //Book myBook = new Book();
            //myBook.Title = "1984";
            //myBook.Pages = 400;
            //object bookObject = myBook; //declaration of obj type

            //Console.WriteLine(bookObject);

            //q2
            //Book myBook = new Book();
            //Console.WriteLine(myBook.ToString());
            //Console.WriteLine(myBook.Equals(myBook));
            //Console.WriteLine(myBook.GetHashCode());
            //Console.WriteLine(myBook.GetType());
        }
    }
}
