using System;
using System.Collections.Generic;

public class Library
{
	public List<ILibraryItem> Items = new List<ILibraryItem>();

	public Library()
	{
        Items.Add(
            new Book
            {
				Number = 1,
				Author = "Jack Black",
                Title = "HeadFirst with C#",
				Pages = 265,
				IsAvailable = true
            }
        );

		Items.Add(
        	new Book
			{
				Number = 2,
				Author = "Bill Murray",
				Title = "Mastering the Console App",
				Pages = 10,
				IsAvailable = true
			}
		);

		Items.Add(
        	new Magazine
			{
				Number = 3,
				Title = "The New Yorker",
				IsAvailable = true
			}
		);

		Items.Add(
        	new Doll
			{
				Number = 4,
				Manufacturer = "Matell",
				Title = "Brain Surgen Barbi",
				IsAvailable = true
			}
		);
    }

	public void ListItems()
	{
		foreach(var item in Items)
		{
            Console.WriteLine(item.ToString());
        }
		
	}

	public ILibraryItem Checkout(int number)
	{
        ILibraryItem item = null;

        try
        {
            item = Items.Find(b => b.Number == number);

            item.Checkout();
        }
		catch (Exception ex)
		{
			// eat it
		}
        
        return item;
    }

	public void Return(int number)
	{
       ILibraryItem item = null;

        try
        {
            item = Items.Find(b => b.Number == number);

            item.Return();
        }
		catch (Exception ex)
		{
			// eat it
		}		
	}
}