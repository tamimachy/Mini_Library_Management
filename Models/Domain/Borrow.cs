namespace Mini_Library_Management.Models.Domain
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public List<BorrowItem> BorrowItems { get; set; }
    }
}
