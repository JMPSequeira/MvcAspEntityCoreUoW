using Core.Models.Abstracts;

namespace Core.Models
{
    public class Customer : AbstractPerson
    {
        public bool IsSubscribbedToNewsLetter { get; set; }
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}