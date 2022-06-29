using System;

namespace Messages {
  public interface GroupUpdated {
    Guid Id { get; set; }
    string Name { get; set; }
    bool IsDefault { get; set; }
  }
}
