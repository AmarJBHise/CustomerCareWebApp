using System;
using System.Collections.Generic;

namespace CustomerCareWebApp.DAl;

public partial class StatusMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();
}
