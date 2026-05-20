namespace SmartLibraryWeb.Models
{
    public class BorrowRecord
    {
        public int RecordID { get; set; }
        public string RecordCode { get; set; } = "";
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public string MemberName { get; set; } = "";
        public string BookTitle { get; set; } = "";
        public string TransactionType { get; set; } = "";
        public DateTime BorrowDate { get; set; } = DateTime.Today;
        public DateTime DueDate { get; set; } = DateTime.Today.AddDays(7);
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = "";
    }
}
