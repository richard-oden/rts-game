using static System.Console;

namespace rts_game;

class Program
{
    private static long _ticks = 0;
    private static int _windowWidth = 120;
    private static int _windowHeight = 30;

    static void Main(string[] args)
    {
        Setup();
        Run();
    }

    public static void Setup()
    {
        CursorVisible = false;
        SetWindowSize(_windowWidth, _windowHeight);
        SetBufferSize(_windowWidth, _windowHeight);
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
