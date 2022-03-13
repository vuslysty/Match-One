using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class GroupRemoveSystem : ReactiveSystem<GameEntity>
{
    readonly Contexts _contexts;

    public GroupRemoveSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        => context.CreateCollector(GameMatcher.Destroyed.Added());

    protected override bool Filter(GameEntity entity) => 
        _contexts.input.isGroupMode && entity.isDestroyed && entity.isPiece;

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            string asset = e.asset.value;
            Vector2Int pos = e.position.value;

            RemoveAssetInAllDirections(pos, asset, true);
        }
    }

    private void RemoveAssetInAllDirections(Vector2Int currentPos, string asset, bool checkDestroyed)
    {
        var entities = _contexts.game.GetEntitiesWithPosition(currentPos);

        foreach (var e in entities)
        {
            if (e == null || e.asset.value != asset)
                return;
        
            if (e.isDestroyed && !checkDestroyed)
                return;

            e.isDestroyed = true;

            RemoveAssetInAllDirections(new Vector2Int(currentPos.x + 1, currentPos.y), asset, false);
            RemoveAssetInAllDirections(new Vector2Int(currentPos.x - 1, currentPos.y), asset, false);
            RemoveAssetInAllDirections(new Vector2Int(currentPos.x, currentPos.y + 1), asset, false);
            RemoveAssetInAllDirections(new Vector2Int(currentPos.x, currentPos.y - 1), asset, false);
        }
        
    }
}