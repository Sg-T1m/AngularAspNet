using System;
using System.Collections.Generic;

namespace AngularAspNet.Model;

public partial class Compatibility
{
    public int ComponentId1 { get; set; }

    public int ComponentId2 { get; set; }

    public virtual Component ComponentId2Navigation { get; set; } = null!;
}
