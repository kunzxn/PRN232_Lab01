using System.Linq;
using BusinessObjects;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountID)
        {
            using var context = new MyStoreContext();
            return context.AccountMembers.FirstOrDefault(a => a.MemberID == accountID);
        }
    }
}
