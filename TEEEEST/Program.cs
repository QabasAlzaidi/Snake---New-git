using TEEEEST;

/// <summary>
/// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
/// </summary>
static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

static void Loop()
{
    // Initialisera spelet
    const int frameRate = 5;
    GameWorld world = new GameWorld();
    ConsoleRenderer renderer = new ConsoleRenderer(world);

    // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans

        Player Snake = new Player();    
        world.GameObjects.Add(Snake);   
    // ...

    // Huvudloopen
    bool running = true;
    while (running)
    {
        // Kom ihåg vad klockan var i början
        DateTime before = DateTime.Now;

        // Hantera knapptryckningar från användaren
        ConsoleKey key = ReadKeyIfExists();
        switch (key)
        {
            case ConsoleKey.Q:
                running = false;
                break;

            case ConsoleKey.W:
                Snake.SetDirection(Player.Direction.upp);

                break;

            case ConsoleKey.A:
                break;

            case ConsoleKey.S:
                break;

            case ConsoleKey.D:

                break;

                // TODO Lägg till logik för andra knapptryckningar
                // ...
        }

        // Uppdatera världen och rendera om
        world.Update();
        renderer.Render();

        // Mät hur lång tid det tog
        double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
        if (frameTime > 0)
        {
            // Vänta rätt antal millisekunder innan loopens nästa varv
            Thread.Sleep((int)frameTime);
        }
    }
}

// Vi kan ev. ha någon meny här, men annars börjar vi bara spelet direkt

//ConsoleRenderer A = new ConsoleRenderer;
//A.WriteBoard();
//Console.ReadKey();
Loop();