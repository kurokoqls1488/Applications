using System;
using System.Collections.Generic;

namespace Applications_project;

public partial class Category
{
    public short Id { get; set; }

    public string NameCategory { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
