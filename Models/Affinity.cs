using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AffinityChart.Enums;

namespace AffinityChart.Models;

[Table("affinityChart", Schema = "CajoneraDB")]
public class Affinity
{
    [Key]
    public int affinity_id { get; set; }
    public string? description { get; set;}
    public EnumStatus status { get; set; }
    
    // Foreign Key
    public string? towards_to { get; set; } = null;
}