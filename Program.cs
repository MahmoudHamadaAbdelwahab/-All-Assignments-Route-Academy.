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

				#region Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory

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

			#endregion

		}
	}
}
