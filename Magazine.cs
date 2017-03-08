using System;

public class Magazine : ILibraryItem, IPublication
{
    public bool IsAvailable { get; set; }

    public int Number { get; set; }

    public string Title { get; set; }
    
    public string Author { get; set; }

    public int Pages { get; set; }

    public DateTime Published { get; set; }

    void Checkout()
    {
        IsAvailable = false;
    }

    void Return()
    {
        IsAvailable = true;
    }

    void ILibraryItem.Checkout()
    {
        throw new NotImplementedException();
    }

    void ILibraryItem.Return()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
	{
        return Number + ": " + Title + ": " + Author + ": " + Pages + ": " + (IsAvailable ? "Available" : "Not Available");
    }
}