using System;
using System.Collections.Generic;

namespace Applications_project.Models;

public partial class Employee
{
    public short Id { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public DateOnly DateOfReceipt { get; set; }

    public DateOnly? DateOfDismissal { get; set; }

    public virtual ICollection<StatusesTask> StatusesTasks { get; set; } = new List<StatusesTask>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
