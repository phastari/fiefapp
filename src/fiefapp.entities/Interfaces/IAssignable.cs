using System;

namespace fiefapp.entities.Interfaces
{
    public interface IAssignable
    {
        public Guid? AssignedTo { get; set; }
    }
}
