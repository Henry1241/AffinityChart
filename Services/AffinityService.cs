using AffinityChart.Models;

namespace AffinityChart.Services;

public static class AffinityService
{
    static List<Affinity> Affinities { get; } = new();
    static int nextId = 1;


    public static List<Affinity> GetAll() => Affinities;

    public static Affinity? Get(int affinity_id) => Affinities.FirstOrDefault(a => a.Affinity_id == affinity_id);

    public static void Add(Affinity affinity)
    {
        affinity.Affinity_id = nextId++;
        Affinities.Add(affinity);
    }

    public static void Delete(int affinity_id)
    {
        var affinity = Get(affinity_id);
        if (affinity is null)
            return;

        Affinities.Remove(affinity);
    }

    public static void Update(Affinity affinity)
    {
        var index = Affinities.FindIndex(a => a.Affinity_id == affinity.Affinity_id);
        if (index == -1)
            return;

        Affinities[index] = affinity;
    }
}