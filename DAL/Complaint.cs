﻿using System;
using System.Collections.Generic;

namespace CustomerCareWebApp.DAl;

public partial class Complaint
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? MobileNumber { get; set; }

    public string? Description { get; set; }

    public int? StatusId { get; set; }

    public DateTime? DateOfRegistration { get; set; }

    public DateTime? ActionDate { get; set; }

    public int? UserId { get; set; }

    public virtual StatusMaster? Status { get; set; }

    public virtual User? User { get; set; }
}
