using System;

namespace Messages {
  /// <summary>
  /// Message that gets send with MassTransit when a group is deleted.
  /// </summary>
  public interface GroupDeleted {
    /// <summary>
    /// Id of the deleted group.
    /// </summary>
    Guid Id { get; set; }
  }
}
