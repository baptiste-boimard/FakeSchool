using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SchoolRepository.Models;

public class Group
{

    public Guid Id { get; set; }
    public string? Name { get; set; } = null;
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Enabled { get; set; }
    /*public ICollection<Student> Students { get; set; }
    public ICollection<Coursegroup> CourseGroups { get; set; }*/

    // protected override void OnModelCreating(ModelBuilder model)
    // {
    //     model.Entity<Group>()
    //         .HasMany(e=> e.Students)
    //         .HasMany(e => e.CourseGroups)
    //         .WithMany(e => e.Groups)
    //         .UsingEntity("coursegroups");
    // }
}
