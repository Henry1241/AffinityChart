using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AffinityChart.Models;

[Table("cajonera", Schema = "CajoneraDB")]
public class Cajonera
{
    [Key]
    public int cajon_id { get; set; }
    public string? name { get; set; }
    public string? favorite_food { get; set; }
    public string? favorite_saga { get; set; }
    public bool has_beaten_morgott { get; set; }
    public bool has_beaten_malenia { get; set; }
    public string[] crimes { get; set; } = Array.Empty<string>();

    // public int Affinity_id { get; set;}
    // public required Affinity Affinity { get; set;}
}