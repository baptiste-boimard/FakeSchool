using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolRepository.DTO;

namespace SchoolRepository.Models;

public class Student
{
    // public Guid Id { get; set; }
    // public string? Name { get; set; } = null;
    // public string? Surname { get; set; } = null;
    // public DateTime Birthday { get; set; }
    // public Guid GroupId { get; set; }
    // public Group Group { get; set; }
    // public DateTime Created { get; set; }
    // public DateTime Modified { get; set; }
    // public bool Enabled { get; set; }
    public Guid Id { get; set; }
    public string? Name { get; set; } = null;
    public string? Surname { get; set; } = null;
    public DateTime Birthday { get; set; }
    public Guid GroupId { get; set; }
    //public Group Group { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Enabled { get; set; }

    // protected override void OnModelCreating(ModelBuilder model)
    // {
    //     model.Entity<Student>()
    //         .HasOne(e => e.Group)
    //         .WithMany(e => e.Students)
    //         .HasForeignKey(e => e.GroupId)
    //         .IsRequired();
    // }
}
