using System;
using System.Collections.Generic;

namespace SchoolRepository.Models;

public partial class Student
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = null;
    public string? Surname { get; set; } = null;
    public DateTime Birthday { get; set; }
    public Guid GroupId { get; set; }
    //
    public virtual Group Group { get; set; }
    //
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Enabled { get; set; }
}
