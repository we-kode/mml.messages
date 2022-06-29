using System;

namespace Messages {
  /// <summary>
  /// Message that gets send with MassTransit when a new group is created. 
  /// </summary>
  public interface GroupCreated {
    /// <summary>
    /// Id of the newly created group.
    /// </summary>
    Guid Id { get; set; }
    
    /// <summary>
    /// Name of the newly created group.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Flag that indicates, whether the created group is a default group
    /// or not.
    /// </summary>
    bool IsDefault { get; set; }
  }
}
