using System;
using System.Collections.Generic;

namespace AngularAspNet.Model;

public partial class ComponentsType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Component> Components { get; set; } = new List<Component>();
}
