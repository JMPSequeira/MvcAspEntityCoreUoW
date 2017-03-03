using System;

namespace Core.Models.Abstracts
{
    public abstract class AbstractPerson : Entity
    {
        public DateTime? DateOfBirth { get; set; }
    }
}