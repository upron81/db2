﻿using System;
using System.Collections.Generic;

namespace TelecomApp.Models;

public partial class EmployeeInfo
{
    public int StaffId { get; set; }

    public string FullName { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public string? Education { get; set; }
}
