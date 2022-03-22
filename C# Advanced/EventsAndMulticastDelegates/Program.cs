

using EventsAndMulticastDelegates;

AudioSystem audioSystem = new AudioSystem();   
RenderEngine renderingEngine = new RenderEngine();

Player player1 = new Player("SteelCow");
Player player2 = new Player("DoggoSilva");
Player player3 = new Player("DoggoDragon");


GameEventManager.TriggerGameStart();
Console.WriteLine("Game is Running....Press any key to end the game.");
GameEventManager.TriggerGameOver();

Console.Read();

 