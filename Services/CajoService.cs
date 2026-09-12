using AffinityChart.Models;

namespace AffinityChart.Serice;

public static class CajoService
{
    static List<Cajonera> Cajoneros { get; }
    static int nextId = 3;
    static CajoService()
    {
        Cajoneros = new List<Cajonera>
        {
            new Cajonera {Cajon_id = 1, Name = "Enrique", FavoriteFood = "Pizza", FavoriteSaga = "Xenoblade Chronicles", HasBeatenMorgott = true, HasBeatenMalenia = false, Crimes = "Suplantacion de identidad"}
        };
    }

    public static List<Cajonera> GetAll() => Cajoneros;

    public static Cajonera? Get(int cajon_id) => Cajoneros.FirstOrDefault(c => c.Cajon_id == cajon_id);

    public static void Add(Cajonera cajonero)
    {
        cajonero.Cajon_id = nextId++;
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
        var index = Cajoneros.FindIndex(c => c.Cajon_id == cajonero.Cajon_id);
        if (index == -1)
            return;

        Cajoneros[index] = cajonero;
    }
}