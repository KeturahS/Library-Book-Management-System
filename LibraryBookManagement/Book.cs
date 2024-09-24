using System;



public class Book
{

	private int ISBN;
	private String Book_title;
	private String Book_author; 
	private int Publication_date;
	private string Category;
	private string BookStatus;



	public Book(int ISBN, String Book_title, String Book_author, int Publication_date, string Category, string BookStatus)
	{
		this.ISBN = ISBN;	
		this.Book_title = Book_title;
		this.Book_author = Book_author;
		this.Publication_date = Publication_date;
		this.Category = Category;
		this.BookStatus = BookStatus;

			
	}


	public int getYear()
		{ return Publication_date; }

	
	public void PrintInfo(
		{
		Console.WriteLine("Publication date: " + Publication_date + ", ISBN: " +ISBN+ ", Book title: "+ Book_title+ ", Book author: " +Book_author +
			 ", Category: " + Category+ ", Book status: "+ BookStatus);
	     }

	public void setISBN(int ISBN)
	{  this.ISBN = ISBN; }

    public void setTitle (string Book_title)
	{ 
	this.Book_title = Book_title;
	}

	public void setAuthor(string Book_author)
	{ this.Book_author = Book_author; }

	public void setPublicationYear(int PublicationDate)
	{ this.Publication_date = Publication_date; }

	public void setCategory(string Category)
			{ this.Category = Category; }

	public void setBookStatus(string bookStatus)
	{
		this.BookStatus= bookStatus;
	}



}
