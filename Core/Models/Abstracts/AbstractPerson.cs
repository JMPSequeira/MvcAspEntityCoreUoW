using System;

namespace Core.Models.Abstracts
{
    public abstract class AbstractPerson : Customers
    {
        public DateTime? DateOfBirth { get; set; }
    }
}