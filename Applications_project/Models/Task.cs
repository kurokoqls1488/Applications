using System;
using System.Collections.Generic;

namespace Applications_project;

public partial class Task
{
    public short Id { get; set; }

    public short IdCategory { get; set; }

    public string Description { get; set; } = null!;

    public short IdSender { get; set; }

    public short IdAudience { get; set; }

    public short IdEmployee { get; set; }

    public short IdStatus { get; set; }

    public virtual Audience IdAudienceNavigation { get; set; } = null!;

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Employee IdEmployeeNavigation { get; set; } = null!;

    public virtual Sender IdSenderNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;
}
