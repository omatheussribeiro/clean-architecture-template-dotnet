using clean_architecture_dotnet.Domain.Entities.Base;

namespace clean_architecture_dotnet.Domain.Entities.Users
{
    public class UserContact : EntityBase
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public bool Status { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<User> User { get; set; }

        public UserContact()
        {
            User = new HashSet<User>();
        }
    }
}
