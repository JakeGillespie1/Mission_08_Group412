using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Mission_08_Group412.Models;

public partial class ToDoList
{
    [Key]
    [Required]
    public int TaskId { get; set; }

    [Required(ErrorMessage = "Please enter the Task Name")]
    public string TaskName { get; set; } = null!;

    public string? DueDate { get; set; }

    [Required(ErrorMessage = "Please enter a valid Quadrant Number")]
    public int QuadrantNumber { get; set; }


    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    public bool? Completed { get; set; }


}