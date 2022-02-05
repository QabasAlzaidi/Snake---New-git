using TEEEEST;

/// <summary>
/// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
/// </summary>
static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

static void Loop()
{
    try
    {


        // Initialisera spelet
        const int frameRate = 5;
        GameWorld world = new GameWorld();
        ConsoleRenderer renderer = new ConsoleRenderer(world);

        // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans

        Player Snake = new Player(new Position(25, 10));
        System.Diagnostics.Debug.WriteLine("LINE 18 position x " + Snake.position.X + " position y " + Snake.position.Y);
        world.GameObjects.Add(Snake);
        System.Diagnostics.Debug.WriteLine("LINE 20 position x " + Snake.position.X + " position y " + Snake.position.Y);

        Food orgfood = world.CreatFood();
        System.Diagnostics.Debug.WriteLine("LINE 23 position x " + Snake.position.X + " position y " + Snake.position.Y);
        world.GameObjects.Add(orgfood);
        System.Diagnostics.Debug.WriteLine("LINE 25 position x " + Snake.position.X + " position y " + Snake.position.Y);

        Wall wallOne = new Wall(new Position(5, 12));
        Wall wallTwo = new Wall(new Position(33, 11));
        world.GameObjects.Add(wallOne);
        world.GameObjects.Add(wallTwo);

        // Huvudloopen
        bool running = true;
        while (running)
        {
            // Kom ihåg vad klockan var i början
            DateTime before = DateTime.Now;

            // Hantera knapptryckningar från användaren
            ConsoleKey key = ReadKeyIfExists();
            switch (key)
            {// TODO Lägg till logik för andra knapptryckningar
                case ConsoleKey.Q:
                    running = false;
                    break;

                case ConsoleKey.W:
                    Snake.SetDirection(Player.Direction.upp);
                    break;

                case ConsoleKey.S:
                    Snake.SetDirection(Player.Direction.ner);
                    break;

                case ConsoleKey.A:
                    Snake.SetDirection(Player.Direction.vänster);
                    break;

                case ConsoleKey.D:
                    Snake.SetDirection(Player.Direction.höger);
                    break;


                    // ...
            }

            // Uppdatera världen och rendera om


            renderer.RenderBlank();
            world.Update();
            System.Diagnostics.Debug.WriteLine("LINE 67 position x " + Snake.position.X + " position y " + Snake.position.Y);
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
    catch (Exception ex) //to crash to program when the snake hits the wall, (managed error)
    {
        if (ex.Message.Contains("Wall crash!!"))

            System.Diagnostics.Debug.WriteLine(ex.Message);
            Console.ReadKey();
    }

}

Loop();

static void WriteGameOver()
    {
        //Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lose 😦 Press 'enter' to quit the game.");
        Console.ReadLine();
    }

// Vi kan ev. ha någon meny här, men annars börjar vi bara spelet direkt

//ConsoleRenderer A = new ConsoleRenderer;
//A.WriteBoard();

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Press 'enter' to start the game :)");

//Console.ReadLine();
//Console.ResetColor();


