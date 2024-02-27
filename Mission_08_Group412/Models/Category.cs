using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission_08_Group412.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

}
}
