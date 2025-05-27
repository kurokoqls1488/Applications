using System;
using System.Collections.Generic;

namespace Applications_project;

public partial class Audience
{
    public short Id { get; set; }

    public string? AudienceNumber { get; set; }

    public string? AudienceName { get; set; }

    public short IdAcademicBuilding { get; set; }

    public virtual EducationalBuilding IdAcademicBuildingNavigation { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    // Новое свойство для отображения
    public string DisplayAudience => $"{AudienceNumber} {AudienceName}";
}
