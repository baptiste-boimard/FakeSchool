using System;
using System.Collections.Generic;
using SchoolRepository.DTO;

namespace SchoolRepository.Models;

public class Coursegroup
{
    public Guid CoursesId { get; set; }
    //public List<Course> Courses { get; set; }
    public Guid GroupsId { get; set; }
    //public List<Group> Groups { get; set; }
}
