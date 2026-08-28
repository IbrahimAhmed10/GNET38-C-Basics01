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

            //q3
            //int pages = 464; //compile-time error

            //q4
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int result = a / b;

            //    Console.WriteLine(result);
            //}
            //catch
            //{
            //    Console.WriteLine("cannot divide  by zero ");
            //}
            //finally
            //{
            //    Console.WriteLine("done");
            //}

            //q5
            //int pages = 300;
            //double pagesAsDouble = pages;
            //Console.WriteLine(pagesAsDouble);

            //q6
            //double price = 49.99;
            //int priceAsint = (int)price;  //cast truncation */
            //Console.WriteLine(priceAsint);
        }
    }
}
