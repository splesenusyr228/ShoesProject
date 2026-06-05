using System;
using System.Collections.Generic;
using ShoesProject.models;

namespace ShoesProject;

public partial class Rol
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
