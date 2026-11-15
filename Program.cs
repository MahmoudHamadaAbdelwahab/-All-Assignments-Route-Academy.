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

		}
	}
}
