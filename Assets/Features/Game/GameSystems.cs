﻿public sealed class GameSystems : Feature
{
    public GameSystems(Contexts contexts)
    {
        // Input
        Add(new InputSystem(contexts));
        Add(new ProcessInputSystem(contexts));

        // Update
        Add(new BoardSystem(contexts));
        Add(new GroupRemoveSystem(contexts));
        Add(new FallSystem(contexts));
        Add(new FillSystem(contexts));
        Add(new ScoreSystem(contexts));

        // View
        Add(new AddViewSystem(contexts));

        // Events (Generated)
        Add(new InputEventSystems(contexts));
        Add(new GameEventSystems(contexts));
        Add(new GameStateEventSystems(contexts));

        Add(new DestroySystem(contexts));
    }
}
