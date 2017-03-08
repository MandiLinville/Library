using System;

public class Book : ILibraryItem, IPublication
{
    public bool IsAvailable { get; set; }

    public int Number { get; set; }

    public string Title { get; set; }
    
    public string Author { get; set; }

    public int Pages { get; set; }

    public DateTime Published { get; set; }

    void ILibraryItem.Checkout()
    {
        IsAvailable = false;
    }

    void ILibraryItem.Return()
    {
        IsAvailable = true;
    }

    public override string ToString()
	{
        return Number + ": " + Title + ": " + Author + ": " + Pages + ": " + (IsAvailable ? "Available" : "Not Available");
    }
}