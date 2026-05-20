namespace SmartLibraryWeb.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookCode { get; set; } = "";
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Category { get; set; } = "";
        public string ISBN { get; set; } = "";
        public int Quantity { get; set; }
        public int AvailableCopies { get; set; }
        public string Status { get; set; } = "";
    }
}
