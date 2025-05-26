using System;
using System.Collections.Generic;

namespace Applications_project.Models;

public partial class StatusesTask
{
    public short Id { get; set; }

    public short IdStatus { get; set; }

    public short IdTask { get; set; }

    public short? IdEmployee { get; set; }

    public DateOnly StatusDate { get; set; }

    public virtual Employee? IdEmployeeNavigation { get; set; }

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual Task IdTaskNavigation { get; set; } = null!;
}
