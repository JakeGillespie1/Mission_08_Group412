using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission_08_Group412.Models;

public class Mission08Context : DbContext
{
    public Mission08Context()
    { }

    public Mission08Context(DbContextOptions<Mission08Context> options) : base(options)
    { }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<ToDoList> ToDoLists { get; set; }
}
