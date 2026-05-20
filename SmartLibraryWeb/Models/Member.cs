namespace SmartLibraryWeb.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberCode { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string UserType { get; set; } = "";
    }
}
