using System;
using System.Collections.Generic;

namespace Applications_project;

public partial class EducationalBuilding
{
    public short Id { get; set; }

    public string FullName { get; set; } = null!;

    public string AbbreviatedName { get; set; } = null!;

    public virtual ICollection<Audience> Audiences { get; set; } = new List<Audience>();
}
