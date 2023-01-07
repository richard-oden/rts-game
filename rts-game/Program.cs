using rts_game.Models;

namespace rts_game;

class Program
{
    private static long _ticks = 0;

    static async Task Main(string[] args)
    {
        Renderer.Setup();
        await Run();
    }

    public static World CreateWorld()
    { 
    
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
