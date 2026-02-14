using System;

namespace Messages.Events
{
    /// <summary>
    /// Message that gets send with MassTransit when a new group is created. 
    /// </summary>
    /// <param name="id">Id of the newly created group.</param>
    /// <param name="name">Name of the newly created group.</param>
    /// <param name="isDefault">Flag that indicates, whether the created group is a default group
    public class GroupCreated(Guid id, string name, bool isDefault)
    {
        /// <summary>
        /// Id of the newly created group.
        /// </summary>
        Guid Id { get; } = id;

        /// <summary>
        /// Name of the newly created group.
        /// </summary>
        string Name { get; } = name;

        /// <summary>
        /// Flag that indicates, whether the created group is a default group
        /// or not.
        /// </summary>
        bool IsDefault { get; } = isDefault;
    }
}
