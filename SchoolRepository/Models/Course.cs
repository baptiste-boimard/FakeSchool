using System;
using System.Collections.Generic;

namespace SchoolRepository.Models;

public partial class Course
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = null;
    public ICollection<Coursegroup> CourseGroups { get; set; }
    public DateTime Date { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Enabled { get; set; }
}
