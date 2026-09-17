using System.ComponentModel.DataAnnotations;

namespace AffinityChart.Models;

public class Cajonera
{
    public int Cajon_id { get; set; }
    public string? Name { get; set; }
    public string? FavoriteFood { get; set; }
    public string? FavoriteSaga { get; set; }
    public bool HasBeatenMorgott { get; set; }
    public bool HasBeatenMalenia { get; set; }
    public string? Crimes { get; set; }

    public int Affinity_id { get; set;}
    public Affinity Affinity { get; set;}
}