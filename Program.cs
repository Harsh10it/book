using System;

struct book
{
	public string title;
	public double price;
	public int bookId;

}
public class Book
{
	public static void Main()
	{
		book books = new book();
		Console.Write("Input the price : ");
		books.price = Convert.ToInt32(Console.ReadLine());

		Console.Write("Input the bookID : ");
		books.bookId = Convert.ToInt32(Console.ReadLine());

		Console.Write("Input name of the book : ");
		books.title = Console.ReadLine();
		First: 
		Console.Write("Input the bookType :\n Press 0 for Magazine \n Press 1 for Novel \n Press 2 for ReferenceBook \n Press 3 for Miscellaneous ");
		int c = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		if (c >= 4 || c < 0)
		{

			Console.WriteLine("Invalid input");
			goto First;
;
		}

        


		Console.WriteLine("bookID = {0}\n Title = {1}\n  Price = {2}", books.bookId, books.title, books.price);


		String[] Type = Enum.GetNames(typeof(bookType));
		Console.WriteLine("bookType = {0}", Type[c]);
	}
}
public enum bookType
{
	Magazine ,
	Novel ,
	ReferenceBook ,
	Miscellaneous 
}

