using System;

public interface IPublication
{
	string Author { get; set; }
	DateTime Published { get; set; }
    int Pages { get; set; }
}