using UnityEngine;

public static class PieceContextExtension
{
    public static GameEntity CreateRandomPiece(this GameContext context, int x, int y)
    {
        var entity = context.CreateEntity();
        entity.isPiece = true;
        entity.isMovable = true;
        entity.isInteractive = true;
        var pos = new Vector2Int(x, y);
        entity.AddInitPosition(pos);
        entity.AddPosition(pos);
        entity.AddAsset("Piece" + Rand.game.Int(6));
        return entity;
    }

    public static GameEntity CreateBlocker(this GameContext context, int x, int y)
    {
        var entity = context.CreateEntity();
        entity.isPiece = true;
        var pos = new Vector2Int(x, y);
        entity.AddInitPosition(pos);
        entity.AddPosition(pos);
        entity.AddAsset("Blocker");
        return entity;
    }
}
