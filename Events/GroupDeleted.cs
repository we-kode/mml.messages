using System;

namespace Messages.Events
{
    /// <summary>
    /// Message that gets send with MassTransit when a group is deleted.
    /// </summary>
    /// <param name="id">Id of the deleted group.</param>
    public class GroupDeleted(Guid id)
    {

        /// <summary>
        /// Id of the deleted group.
        /// </summary>
        Guid Id { get; set; } = id;
    }
}
