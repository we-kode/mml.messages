using System;

namespace Messages.Events.Interfaces {
  /// <summary>
  /// Message that gets send with MassTransit when a group is deleted.
  /// </summary>
  public interface IGroupDeleted {
    /// <summary>
    /// Id of the deleted group.
    /// </summary>
    Guid Id { get; set; }
  }
}
