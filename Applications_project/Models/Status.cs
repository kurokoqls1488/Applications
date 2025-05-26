using System;
using System.Collections.Generic;

namespace Applications_project.Models;

public partial class Status
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<StatusesTask> StatusesTasks { get; set; } = new List<StatusesTask>();
}
