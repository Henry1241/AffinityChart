using AffinityChart.Data;
using AffinityChart.Models;

namespace AffinityChart.Services;

public class CajoService
{
    static List<Cajonera> Cajoneros { get; } = new();
    static int nextId = 1;

    static CajoService()
    {
        Cajoneros = new List<Cajonera>
        {
            
        };
    }

    public static List<Cajonera> GetAll() => Cajoneros;

    public static Cajonera? Get(int cajon_id) => Cajoneros.FirstOrDefault(c => c.cajon_id == cajon_id);

    public static void Add(Cajonera cajonero)
    {
        cajonero.cajon_id = nextId++;
        Cajoneros.Add(cajonero);
    }

    public static void Delete(int cajon_id)
    {
        var cajonero = Get(cajon_id);
        if (cajonero is null)
            return;

        Cajoneros.Remove(cajonero);
    }

    public static void Update(Cajonera cajonero)
    {
        var index = Cajoneros.FindIndex(c => c.cajon_id == cajonero.cajon_id);
        if (index == -1)
            return;

        Cajoneros[index] = cajonero;
    }
}