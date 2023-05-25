﻿using System;
using System.Collections.Generic;

namespace MyShopNet7.Entities;

public partial class RoleAction
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public int WebActionId { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual WebAction WebAction { get; set; } = null!;
}
