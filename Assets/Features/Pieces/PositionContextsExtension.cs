public partial class Contexts {

    public const string Position = "Position";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, UnityEngine.Vector2Int>(
            Position,
            game.GetGroup(GameMatcher.Position),
            (e, c) => ((PositionComponent)c).value));
    }
}

public static partial class ContextsExtensions {

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithPosition(this GameContext context, UnityEngine.Vector2Int value) {
        return ((Entitas.EntityIndex<GameEntity, UnityEngine.Vector2Int>)context.GetEntityIndex(Contexts.Position)).GetEntities(value);
    }
}
