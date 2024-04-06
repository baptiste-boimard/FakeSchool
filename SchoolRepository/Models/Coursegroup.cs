using System;
using System.Collections.Generic;

namespace SchoolRepository.Models;

public partial class Coursegroup
{
    public Guid CoursesId { get; set; }
    public Guid GroupsId { get; set; }
}
