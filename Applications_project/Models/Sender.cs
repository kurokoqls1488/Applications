using System;
using System.Collections.Generic;

namespace Applications_project.Models;

public partial class Sender
{
    public short Id { get; set; }

    public string FullName { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
