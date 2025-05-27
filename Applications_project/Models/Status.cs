using System;
using System.Collections.Generic;

namespace Applications_project;

public partial class Status
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
