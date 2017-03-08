using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library();

            library.ListItems();
            var item = library.Checkout(1);

            if(item != null)
            {
                Console.WriteLine("Checked Out: " + item.ToString());
            }
            
            library.ListItems();
        }
    }
}
