using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace c_Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            /*question: Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            both title and upperTitle to show that title did not change.*/
            string title = "clean code";

            string upperTitle = title.ToUpper();

            Console.WriteLine("title: " + title);
            Console.WriteLine("upperTitle: " + upperTitle);
            #endregion
            #region Task02
            /*question: Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            to check if they point to the same object in memory.*/
            string str1 = "Clean Code";
            string str2 = "Clean Code";

            bool result = ReferenceEquals(str1, str2);

            Console.WriteLine(result);
            #endregion
            #region Task03
            /*question: Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            object. Print the final result.*/
            StringBuilder bookList03 = new StringBuilder();

            bookList03.Append("Book List");
            bookList03.Append(" - Updated");

            Console.WriteLine(bookList03);

            #endregion

            #region Task04
            /*question: Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            Print the result.*/
            StringBuilder bookList04 = new StringBuilder();

            bookList04.Append("Book List");
            bookList04.Append(" - Updated");

            bookList04.Replace("Book List", "Library");

            Console.WriteLine(bookList04);
            #endregion
            #region Task05
            /*question: Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            Pages: 464" using the + operator..*/
            string title05 = "Clean Code";
            int pages05 = 464;

            string result05 = "Book: " + title05 + ",\nPages: " + pages05;

            Console.WriteLine(result05);
            #endregion
            #region Task06
            /*question: Build the same sentence as above, but using string interpolation ($"...").*/
            string title06 = "Clean Code";
            int pages06 = 464;

            string result06 = $"Book: {title06},\nPages: {pages06}";

            Console.WriteLine(result06);

            #endregion
            #region Task07 
            /*question: Build the same sentence again, but using string.Format().*/
            string title07 = "Clean Code";
            int pages07 = 464;

            string result07 = string.Format("Book: {0},\nPages: {1}", title07, pages07);

            Console.WriteLine(result07);
            #endregion
            #region Task08
            /*question: Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            300, otherwise prints "Short Book".*/
            int pages08 = 464;

            if (pages08 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion
            #region Task09
            /*question: Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            greater than 300 and isAvailable is true. Use the && operator.*/
            int pages = 464;
            bool isAvailable = true;

            if (pages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion
            #region Task10
            /*question: Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.*/
            string title10 = "Refactoring";

            switch (title10)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
            #region Task11
            /*question:Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            variable sizeLabel (same rule as question 8: long if pages > 300).*/
            int pages11 = 464;

            string sizeLabel = pages11 > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);

            #endregion
           
        }
    }
}
   