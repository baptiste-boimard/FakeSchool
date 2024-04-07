using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolRepository.Models;

public partial class Group
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; } = null;
    public ICollection<Course> Courses { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Enabled { get; set; }
}
