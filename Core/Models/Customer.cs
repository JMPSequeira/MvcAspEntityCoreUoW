using Core.Models.Abstracts;

namespace Core.Models
{
    public class Customer : AbstractPerson
    {
        public bool IsSubscribedToNewsletter { get; set; }
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
        public SalesAgent SalesAgent { get; set; }
        public int SalesAgentId { get; set; }
    }
}