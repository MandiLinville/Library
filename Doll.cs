using System;

public class Doll : ILibraryItem, IToy
{
    public bool IsAvailable { get; set; }

    public string Manufacturer { get; set; }

    public int Number { get; set; }

    public string Title { get; set; }

    public void Checkout()
    {
		// do something specific to toys
        IsAvailable = false;
    }

	public void Return()
	{
		// do something specific to toys
		IsAvailable = true;
	}

    public override string ToString()
	{
        return Number + ": " + Title + ": " + Manufacturer + ": " + (IsAvailable ? "Available" : "Not Available");
    }
}