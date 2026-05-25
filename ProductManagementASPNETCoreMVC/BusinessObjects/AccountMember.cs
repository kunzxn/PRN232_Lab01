using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects
{
    [Table("AccountMember")]
    public class AccountMember
    {
        [Key]
        public string MemberID { get; set; }
        public string MemberPassword { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public int MemberRole { get; set; }
    }
}
