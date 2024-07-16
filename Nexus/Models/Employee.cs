﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    //[Required(ErrorMessage = "Please enter Name.")]
    public string Name { get; set; } = null!;
    //[Required(ErrorMessage = "Please enter Email.")]
    public string Email { get; set; } = null!;

    //[Required(ErrorMessage = "Please enter password")]
    public string Password { get; set; } = null!;
    public int RoleId { get; set; }

    public int ShopId { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual RetailShop Shop { get; set; } = null!;


    [NotMapped]
    public string RoleName { get; set; }
}
