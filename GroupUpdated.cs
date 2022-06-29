using System;

namespace Messages {
  /// <summary>
  /// Message that gets send with MassTransit when a group is updated. 
  /// </summary>
  public interface GroupUpdated {
    /// <summary>
    /// Id of the updated group.
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Name of the updated group.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Flag that indicates, whether the updated group is a default group
    /// or not.
    /// </summary>
    bool IsDefault { get; set; }
  }
}
