using System;

namespace Messages {
  public interface GroupCreated {
    Guid Id { get; set; }
    string Name { get; set; }
    bool IsDefault { get; set; }
  }
}
