namespace Mini_Library_Management.Models.Domain
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsActive { get; set; }
    }
}
