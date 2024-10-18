﻿using System;
using System.Collections.Generic;

namespace TelecomApp.Models;

public partial class Call
{
    public int CallId { get; set; }

    public int ContractId { get; set; }

    public DateTime CallDate { get; set; }

    public int CallDuration { get; set; }

    public virtual Contract Contract { get; set; } = null!;
}