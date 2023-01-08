using rts_game.Enumerations;
using rts_game.Models;

namespace rts_game;

class Program
{
    private static long _ticks = 0;
    private static Random _random = new Random();

    static async Task Main(string[] args)
    {
        Renderer.Setup();
        await Run();
    }

    public static HashSet<Faction> CreateFactions(int numFactions, Difficulty difficulty)
    {
        var playerCurrency = difficulty switch
        {
            Difficulty.Easy => 75,
            Difficulty.Medium => 50,
            Difficulty.Hard => 25
        };

        var factions = new HashSet<Faction>() { Faction.InitialPlayerFaction("Player", playerCurrency) };

        for (var i = 1; i < numFactions; i++)
        {
            var hostility = difficulty switch
            {
                Difficulty.Easy => (Hostility)_random.Next(0, 3),
                Difficulty.Medium => (Hostility)_random.Next(1, 4),
                Difficulty.Hard => (Hostility)_random.Next(2, 5)
            };

            var computerCurrency = difficulty switch
            {
                Difficulty.Easy => 25,
                Difficulty.Medium => 50,
                Difficulty.Hard => 75
            };

            factions.Add(Faction.InitialComputerFaction($"Computer {i}", hostility, computerCurrency));
        }

        return factions;
    }

    public static World CreateWorld(IEnumerable<Faction> factions, int worldWidth, int worldHeight)
    {
        var world = new World() { Width = worldWidth, Height = worldHeight };
        var startingCoordinates = new HashSet<Coordinate>();

        foreach (var faction in factions)
        {
            var startingCoordinate = (Coordinate)default;

            while (startingCoordinates == default || startingCoordinates.Any(_ => _.DistanceTo(startingCoordinate) < 10))
            {
                startingCoordinate = new Coordinate
                {
                    X = _random.Next(4, worldWidth - 6), // ensuring that all starting coordinates are
                    Y = _random.Next(4, worldHeight - 6) // at least 5 spaces from world border
                };
            }

            startingCoordinates.Add(startingCoordinate);
        }

        return world;
    }

    public static async Task Run()
    {
        var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(1.0 / 60));

        while (true)
        {

            await periodicTimer.WaitForNextTickAsync(CancellationToken.None);

            _ticks++;
        }
    }
}
