using System;
using System.Collections.Generic;

namespace MiniProject.model;

public partial class DoingTask
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public DateTime? DeedLine { get; set; }
}
