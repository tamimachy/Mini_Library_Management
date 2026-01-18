namespace Mini_Library_Management.Models.Domain
{
    public class BorrowItem
    {
        public int BorrowItemId { get; set; }
        public int BorrowId { get; set; }
        public int BookId { get; set; }
    }
}
