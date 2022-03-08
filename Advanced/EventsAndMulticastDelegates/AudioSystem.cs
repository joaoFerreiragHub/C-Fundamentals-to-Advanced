using EventsAndMulticastDelegates;

public class AudioSystem
{

    public AudioSystem()
    {
        GameEventManager.OnGameStart += StartGame;
        GameEventManager.OnGameOver += GameOver;
    }
    private void StartGame()
    {
        Console.WriteLine("Audio Sytem Started");
        Console.WriteLine("Playing Audio...");
    }

    private void GameOver()
    {
        Console.WriteLine("Audio System Stopped");
    }
}