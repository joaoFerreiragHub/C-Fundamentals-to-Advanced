using EventsAndMulticastDelegates;

public class RenderEngine
{
    public RenderEngine()
    {
        GameEventManager.OnGameStart += StartGame; // o += faz com que nao haja override, nos nao queremos fazer override
        GameEventManager.OnGameOver += GameOver; // se usarmos event evitamos o erro de dar override
    }
    private void StartGame()
    {
        Console.WriteLine("Rendering Engine Started");
        Console.WriteLine("Drawing Visuals...");
    }

    private void GameOver()
    {
        Console.WriteLine("Rendering Engine Stopped");
    }
}