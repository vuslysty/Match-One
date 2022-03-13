using Entitas;

public class DestroySystem : ICleanupSystem
{
    readonly Contexts _contexts;

    public DestroySystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Cleanup()
    {
        foreach (var e in _contexts.game.GetGroup(GameMatcher.Destroyed).GetEntities())
        {
            e.Destroy();
        }
    }
}