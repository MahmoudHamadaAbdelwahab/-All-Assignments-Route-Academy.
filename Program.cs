using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Assignments 2

			#region Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.
			//Books objBook = new Books();
			//objBook.Title = "C# Programming";
			//objBook.Page = 250; 

			//object objNawe = objBook;

			//Console.WriteLine(((Books)objNawe).Title);
			//Console.WriteLine(((Books)objNawe).Page);
			#endregion

			#region Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
			//Console.WriteLine(objBook.ToString());
			//Console.WriteLine(objBook.Equals(objBook));
			//Console.WriteLine(objBook.GetHashCode());
			//Console.WriteLine(objBook.GetType()); 
			#endregion

			#region Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it .int pages = "464"; ---> it's compile-time error (syntax error)
			//int pages = int.Parse("464");
			#endregion

			#region Compile-time error — you can't put text (string) into an int variable.
			//Console.WriteLine("pelase enter pages of the books");
			//	int pages = Convert.ToInt32(Console.ReadLine());
			//	Console.WriteLine($"pages of the books : {pages}"); 
			#endregion

			#region Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannotdivide by zero", and then prints "Done" in a finally block.
			//int firstNum = 10;
			//int secondNum = 0;
			//try
			//{
			//	int divides = firstNum / secondNum;
			//	Console.WriteLine(divides);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}
			//finally
			//{
			//	Console.WriteLine("Done");
			//}

			#endregion


			#region Declare an int pages = 300; then store it in a double variable without using a cast.
			//int pages1 = 300;
			//double pages2 = pages1; 
			#endregion


			#region Declare a double price = 49.99; then convert it into an int using a cast.
			//double price = 49.99;
			//int price1 = (int)price; 
			#endregion

			#region Given string pagesText = "464";, convert it into an int using the Convert class.
			//string pagesText = "464";
			//int pagesNum = Convert.ToInt32(pagesText); 
			#endregion

			#region Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
			//string yearText = "2023";
			//int yearNum = int.Parse(yearText);

			//string badText = "abc";
			//int badNum = 0;
			//bool isParse = int.TryParse(badText, out badNum);
			//Console.WriteLine(isParse);
			//Console.WriteLine(badNum); 
			#endregion

			#region Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
			//int pageN = 464;
			//string pageS = pageN.ToString();
			//Console.WriteLine("value" + pageS);
			//Console.WriteLine("type" + pageS.GetType()); 
			#endregion

			#region Declare int copies = 100;. Box it into an object variable, then unbox it back into a new intvariable, and print both.
			//int copies = 100;
			//object obj = copies;
			//int objCopies = (int)obj;
			//Console.WriteLine(obj);
			//Console.WriteLine(objCopies); 
			#endregion


			#region Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
			//int? year = null;
			//Console.WriteLine($"Has value: {year.HasValue}");
			//year = 2023;
			//Console.WriteLine($"Year value: {year.Value}"); 
			#endregion

			#region Declare a string? reviewer = null;. Print whether it is null.
			//string? reviewer = null;
			//Console.WriteLine($"Is reviewer null: {reviewer == null}");
			#endregion

			#region Declare a Book? book = null;. Use?. to safely read book.Title without crashing theprogram, and print the result.
			//Books? book = null;
			//string? title = book?.Title;
			//Console.WriteLine($"Q13 - Book title: {title ?? "null"}");
			#endregion

			#region Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??=to assign title the value "Untitled" only if it's still null.
			//Console.WriteLine($"Q14 - Display title: {title ?? "Untitled"}");
			//title ??= "Untitled";
			//Console.WriteLine($"Q14 - Assigned title: {title}");
			#endregion

			#region Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullablestring confirmedName using the ! operator.
			//string? name = "Ahmed";
			//string confirmedName = name!;
			//Console.WriteLine($"Q15 - Confirmed name: {confirmedName}");
			#endregion

			#endregion

			#region Assignments 3

			#region Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change
			//string title = "clean code";
			//string upperTitle = title.ToUpper();
			//Console.WriteLine($"Title: {title} , UpperTitle: {upperTitle}");
			#endregion

			#region Declare Two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory

			#endregion

			#region Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the sameobject.Print the final result.
			//StringBuilder strBuild = new StringBuilder();
			//strBuild.Append("Book List");
			//strBuild.Append(" - Updated");
			//Console.WriteLine(strBuild.ToString());
			#endregion

			#region Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".Print the result.
			//strBuild.Replace("Book List", "Library");
			//Console.WriteLine(strBuild.ToString());
			#endregion

			#region  Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,Pages: 464" using the + operator
			//string title = "Clean Code";
			//int pages = 464;
			//Console.WriteLine("Book: " + title + ", Pages: " + pages);
			#endregion

			#region Build the same sentence as above, but using string interpolation ($"...").
			//Console.WriteLine($"Book: {title}, Pages: {pages}");
			#endregion

			#region Build the same sentence again, but using string.Format().
			//Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
			#endregion

			#region Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than300, otherwise prints "Short Book
			//int pages = 464;
			//if(pages > 300)
			//	Console.WriteLine("Long Book");
			//else
			//	Console.WriteLine("Short Book");
			#endregion

			#region Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages isgreater than 300 and isAvailable is true.Use the && operator
			//bool isAvailable = true;
			//if(pages > 300 && isAvailable)
			//	Console.WriteLine("You can borrow this book");
			#endregion

			#region Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else  
			//string title = "Refactoring";
			//switch(title)
			//{
			//	case "Clean Code":
			//		Console.WriteLine("Book: Great choice!");
			//		break;
			//	case "Refactoring":
			//		Console.WriteLine("Book: Nice pick!");
			//		break;
			//	default:
			//		Console.WriteLine("Never heard of it");
			//		break;
			//}
			#endregion

			#region  Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into avariable sizeLabel(same rule as question 8: long if pages > 300).
			//int pages = 464;
			//string sizeLable = pages > 300 ? "long book" : "short book";
			//Console.WriteLine(sizeLable);

			#endregion

			#region Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.
			//string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
			//for(int i = 0; i < books.Length; i++)
			//{
			//	Console.WriteLine($"book {i+1} : {books[i]}");
			//}
			#endregion

			#region Using the same books array, use a while loop to print every book title
			//int counter = 0;
			//while (counter < books.Length)
			//{
			//	Console.WriteLine($"book {counter+1} : {books[counter]}");
			//	counter++;
			//}
			#endregion

			#region Write a do-while loop that prints "Checking book..." exactly 3 times.
			//int count = 0;
			//do
			//{
			//	Console.WriteLine("Checking book...");
			//	count++;
			//}
			//while (count < 3);
			#endregion

			#region Using the same books array, use a foreach loop to print every book title.
			//foreach (string book in books)
			//{
			//	Console.WriteLine($"book : {book}");
			//}

			#endregion

			#region Using the same books array, loop through it and print each title, but stop completely (break) onceyou reach "Refactoring"
			//for (int i = 0; i < books.Length; i++)
			//{ 
			//	if(books[i] == "Refactoring")
			//		break;

			//	Console.WriteLine($"book {i + 1} : {books[i]}");
			//}
			#endregion

			#region Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
			//for (int i = 0; i < books.Length; i++)
			//{ 
			//	if(books[i] == "The Pragmatic Programmer")
			//		continue;

			//	Console.WriteLine($"book {i + 1} : {books[i]}");
			//}

			#endregion

			#region Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything.

			//void PrintFirstBook()
			//{
			//	if (books.Length == 0)
			//		return;

			//	Console.WriteLine(books[0]);
			//}
			#endregion

			#endregion

			#region Assignments 4
			using System;

namespace LibraryAssignment
	{
		class Program
		{
			static void Main(string[] args)
			{
				#region Problem 1: One-Dimensional Array
				/*
				 * Problem 1:
				 * Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. 
				 * Print the second price (index 1).
				 */
				Console.WriteLine("--- Problem 1 ---");
				double[] prices = { 25.5, 40.0, 33.75 };
				Console.WriteLine("Second price: " + prices[1]);
				Console.WriteLine();
				#endregion

				#region Problem 2: Multidimensional Array
				/*
				 * Problem 2:
				 * Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies 
				 * and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
				 */
				Console.WriteLine("--- Problem 2 ---");
				int[,] shelfCopies = {
				{ 3, 5 }, // Shelf 0
                { 1, 4 }  // Shelf 1
            };
				Console.WriteLine("Copies on shelf 1, slot 0: " + shelfCopies[1, 0]);
				Console.WriteLine();
				#endregion

				#region Problem 3: Basic Void Method
				/*
				 * Problem 3:
				 * Write a method called PrintWelcomeMessage that takes no parameters and prints
				 * "Welcome to the Library!". Call it from Main.
				 */
				Console.WriteLine("--- Problem 3 ---");
				PrintWelcomeMessage();
				Console.WriteLine();
				#endregion

				#region Problem 4: Method with a Parameter
				/*
				 * Problem 4:
				 * Write a method PrintBookTitle(string title) that prints "Book title: " + title. 
				 * Call it with "Clean Code".
				 */
				Console.WriteLine("--- Problem 4 ---");
				PrintBookTitle("Clean Code");
				Console.WriteLine();
				#endregion

				#region Problem 5: Pass by Value (Value Type)
				/*
				 * Problem 5:
				 * Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
				 * int pages = 400; and print pages afterward. What do you expect to see, and why?
				 */
				Console.WriteLine("--- Problem 5 ---");
				int pages = 400;
				AddBonusPages(pages);
				Console.WriteLine("Pages after method call: " + pages);
				// Explanation: I expect to see 400. Because 'int' is a value type, C# passes a copy 
				// of the variable to the method. Adding 50 only changes the copy inside the method, 
				// leaving the original 'pages' variable in Main unchanged.
				Console.WriteLine();
				#endregion

				#region Problem 6: Pass by Value (Reference Type)
				/*
				 * Problem 6:
				 * Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
				 * with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
				 * see, and why?
				 */
				Console.WriteLine("--- Problem 6 ---");
				double[] discountPrices = { 25.5, 40.0 };
				ApplyDiscount(discountPrices);
				Console.WriteLine("First price after discount: " + discountPrices[0]);
				// Explanation: I expect to see 20.5. Arrays are reference types, meaning the variable 
				// holds a memory address pointing to the array. When passed to the method, the method 
				// accesses and modifies the exact same array in memory.
				Console.WriteLine();
				#endregion

				#region Problem 7: Pass by Reference (ref keyword)
				/*
				 * Problem 7:
				 * Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
				 * Call it and print pages afterward. How is the result different from question 5?
				 */
				Console.WriteLine("--- Problem 7 ---");
				int refPages = 400;
				AddBonusPagesByRef(ref refPages);
				Console.WriteLine("Pages after ref method call: " + refPages);
				// Explanation: The result is now 450 instead of 400. Using the 'ref' keyword forces C# 
				// to pass a reference to the original variable rather than a copy, so changes inside 
				// the method directly update the original variable in Main.
				Console.WriteLine();
				#endregion

				#region Problem 8: Replacing an Array using ref
				/*
				 * Problem 8:
				 * Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
				 * new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
				 * afterward.
				 */
				Console.WriteLine("--- Problem 8 ---");
				ReplaceArray(ref discountPrices);
				Console.WriteLine("New array length: " + discountPrices.Length);
				Console.WriteLine();
				#endregion

				#region Problem 9: Output Parameters (out keyword)
				/*
				 * Problem 9:
				 * Write a method bool TryGetPrice(string title, out double price) that returns true and sets
				 * price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it
				 * and print the price if found.
				 */
				Console.WriteLine("--- Problem 9 ---");
				if (TryGetPrice("Clean Code", out double foundPrice))
				{
					Console.WriteLine("Book found! Price: " + foundPrice);
				}
				else
				{
					Console.WriteLine("Book not found.");
				}
				Console.WriteLine();
				#endregion

				#region Problem 10: Optional Parameters
				/*
				 * Problem 10:
				 * Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
				 * it once with only a title, and once passing both a title and pages.
				 */
				Console.WriteLine("--- Problem 10 ---");
				PrintBookInfo("The Pragmatic Programmer");
				PrintBookInfo("Clean Code", 464);
				Console.WriteLine();
				#endregion

				#region Problem 11: Named Arguments
				/*
				 * Problem 11:
				 * Using the PrintBookInfo method from the question above, call it by naming the
				 * parameters, passing pages before title.
				 */
				Console.WriteLine("--- Problem 11 ---");
				PrintBookInfo(pages: 520, title: "Design Patterns");
				Console.WriteLine();
				#endregion

				#region Problem 12: Params Keyword
				/*
				 * Problem 12:
				 * Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
				 * Call it with three book titles.
				 */
				Console.WriteLine("--- Problem 12 ---");
				PrintAllTitles("Clean Code", "Refactoring", "Head First C#");
				Console.WriteLine();
				#endregion
			}

			// --- Helper Methods ---

			// Method for Problem 3
			static void PrintWelcomeMessage()
			{
				Console.WriteLine("Welcome to the Library!");
			}

			// Method for Problem 4
			static void PrintBookTitle(string title)
			{
				Console.WriteLine("Book title: " + title);
			}

			// Method for Problem 5
			static void AddBonusPages(int pages)
			{
				pages = pages + 50;
			}

			// Method for Problem 6
			static void ApplyDiscount(double[] prices)
			{
				prices[0] = prices[0] - 5;
			}

			// Method for Problem 7
			static void AddBonusPagesByRef(ref int pages)
			{
				pages = pages + 50;
			}

			// Method for Problem 8
			static void ReplaceArray(ref double[] prices)
			{
				prices = new double[] { 10.0, 12.5, 15.0 };
			}

			// Method for Problem 9
			static bool TryGetPrice(string title, out double price)
			{
				if (title == "Clean Code")
				{
					price = 25.5;
					return true;
				}
				else
				{
					price = 0;
					return false;
				}
			}

			// Method for Problem 10 & 11
			static void PrintBookInfo(string title, int pages = 300)
			{
				Console.WriteLine($"Title: {title}, Pages: {pages}");
			}

			// Method for Problem 12
			static void PrintAllTitles(params string[] titles)
			{
				foreach (string title in titles)
				{
					Console.WriteLine(title);
				}
			}
		}
	}





	#endregion
}
	}
}
