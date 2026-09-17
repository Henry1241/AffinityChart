using AffinityChart.Enums;

namespace AffinityChart.Models;

public class Affinity
{
    public int Affinity_id { get; set; }
    public string? Description { get; set;}
    public EnumStatus Status { get; set; }
    
    // Foreign Key
    public required ICollection<Cajonera> Cajoneros { get; set; }
}