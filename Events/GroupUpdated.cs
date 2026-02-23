using System;

namespace Messages.Events
{
    /// <summary>
    /// Message that gets send with MassTransit when a group is updated. 
    /// </summary>
    /// <param name="id">Id of the updated group.</param>
    /// <param name="name">Name of the updated group.</param>
    /// <param name="isDefault">Flag that indicates, whether the updated group is a default group
    public class GroupUpdated(Guid id, string name, bool isDefault)
    {
        /// <summary>
        /// Id of the updated group.
        /// </summary>
        public Guid Id { get; } = id;

        /// <summary>
        /// Name of the updated group.
        /// </summary>
        public string Name { get; } = name;

        /// <summary>
        /// Flag that indicates, whether the updated group is a default group
        /// or not.
        /// </summary>
        public bool IsDefault { get; } = isDefault;
    }
}
