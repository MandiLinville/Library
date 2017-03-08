public interface ILibraryItem
{
	int Number { get; set; }
    string Title { get; set; }
    bool IsAvailable { get; set; }

    void Checkout();
    void Return();
    
    string ToString();
}
