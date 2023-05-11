using System;
using System.Collections.Generic;

namespace AngularAspNet.Model;

public partial class Component
{
    public int Id { get; set; }

    public int ComponentsTypeId { get; set; }

    public int ManufacturersId { get; set; }

    public string? Name { get; set; }

    public string? Price { get; set; }

    public int? CompatibilitiesId { get; set; }

    public string? Capacity { get; set; }

    public string? Type { get; set; }

    public string? Weight { get; set; }

    public string? Img { get; set; }

    public string? Socket { get; set; }

    public int? ReleaseYear { get; set; }

    public int? TotalNumberOfCores { get; set; }

    public string? CpubaseFrequency { get; set; }

    public int? VideoMemorySize { get; set; }

    public string? MemoryType { get; set; }

    public int? NumberOfMemorySlots { get; set; }

    public int? PowerDissipation { get; set; }

    public int? HeatPipesDiameter { get; set; }

    public int? NumberOfFansIncluded { get; set; }

    public int? PowerMominal { get; set; }

    public string? Collor { get; set; }

    public int? AllMemory { get; set; }

    public int? VolumeOfOneMemoryModule { get; set; }

    public int? NumberOfModulesIncluded { get; set; }

    public string? ClockFrequency { get; set; }

    public virtual ICollection<Compatibility> Compatibilities { get; set; } = new List<Compatibility>();

    public virtual ComponentsType ComponentsType { get; set; } = null!;

    public virtual Manufacturer Manufacturers { get; set; } = null!;
}
