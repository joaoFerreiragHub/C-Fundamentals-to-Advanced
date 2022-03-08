using EventsAndMulticastDelegates;

public class Player
{
    public Player(string name)
    {
        PlayerName = name;
        GameEventManager.OnGameStart += StartGame;
        GameEventManager.OnGameOver += GameOver;
    }

    public string PlayerName { get; set; }

    private void GameOver()
    {
        Console.WriteLine($"Removing Player with ID :  { PlayerName}");
    }

    private void StartGame()
    {
        Console.WriteLine($"Spawning Player with ID :  { PlayerName}");
    }
}