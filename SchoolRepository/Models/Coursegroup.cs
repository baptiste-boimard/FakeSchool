using System;
using System.Collections.Generic;

namespace SchoolRepository.Models;

public partial class Coursegroup
{
    public Guid CoursesId { get; set; }
    public Course Course { get; set; }
    public Guid GroupsId { get; set; }
    public Group Group { get; set; }
}
